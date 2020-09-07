using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using BusPass.Shared.HelperEntities;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;

namespace BusPass.Client.Helpers {
    public class HttpService : IHttpService {
        private HttpClient _httpClient;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private IConfiguration _configuration;

        public HttpService (
            HttpClient httpClient,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService,
            IConfiguration configuration
        ) {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
            _configuration = configuration;
        }
        public async Task<T> Post<T> (string uri, T data) {
            var request = new HttpRequestMessage (HttpMethod.Post, uri);
            request.Content = new StringContent (JsonSerializer.Serialize (data), Encoding.UTF8, "application/json");
            return await sendRequest<T> (request);
        }

        public async Task<T> Get<T> (string uri) {
            var request = new HttpRequestMessage (HttpMethod.Get, uri);
            return await sendRequest<T> (request);
        }

        public async Task<T> Put<T> (string uri) {
            var request = new HttpRequestMessage (HttpMethod.Put, uri);
            return await sendRequest<T> (request);

        }
        private async Task<T> sendRequest<T> (HttpRequestMessage request) {
            // add jwt auth header if user is logged in and request is to the api url
            var user = await _localStorageService.GetItemAsync<LoginUser> ("user");
            var isApiUrl = !request.RequestUri.IsAbsoluteUri;
            if (user != null && isApiUrl)
                request.Headers.Authorization = new AuthenticationHeaderValue ("Bearer", user.Token);

            var response = await _httpClient.SendAsync (request);

            // auto logout on 401 response
            if (response.StatusCode == HttpStatusCode.Unauthorized) {
                _navigationManager.NavigateTo ("logout");
                return default;
            }

            //throw exception on error response
            if (!response.IsSuccessStatusCode) {
                var error = await response.Content.ReadAsStringAsync ().ConfigureAwait (continueOnCapturedContext: false);
                throw new Exception (error);
            }

            return await response.Content.ReadFromJsonAsync<T> ().ConfigureAwait (continueOnCapturedContext: false);
        }
    }
}