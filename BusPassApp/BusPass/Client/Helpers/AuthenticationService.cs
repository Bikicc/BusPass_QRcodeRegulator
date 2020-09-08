using System.Threading.Tasks;
using BusPass.Shared.HelperEntities;
using Microsoft.AspNetCore.Components;
using Blazored.LocalStorage;


namespace BusPass.Client.Helpers {
    public class AuthenticationService : IAuthenticationService {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        public LoginUser user { get; private set; }
        public AuthenticationService (
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService
        ) {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize () {
            this.user = await _localStorageService.GetItemAsync<LoginUser> ("user");
        }

        public async Task Login (LoginUser user) {
            LoginUser logedUser = await _httpService.Post ("/api/user/loginUser", user);
            await _localStorageService.SetItemAsync ("user", logedUser);
            await Initialize ();
        }

        public async Task Logout () {
            this.user = null;
            await _localStorageService.RemoveItemAsync ("user");
            _navigationManager.NavigateTo ("login");
        }

        public bool checkIfAdmin () {
            // User us = await _localStorageService.GetItemAsync<User> ("user");
            return this.user.Role == "Admin" ? true : false;
        }

    }
}