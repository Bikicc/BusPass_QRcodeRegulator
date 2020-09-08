using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using BusPass.Client.Helpers;
using BusPass.Client.Repository;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
namespace BusPass.Client {
    public class Program {
        public static async Task Main (string[] args) {
            var builder = WebAssemblyHostBuilder.CreateDefault (args);
            builder.RootComponents.Add<App> ("app");

            builder.Services
                .AddTransient (sp => new HttpClient { BaseAddress = new Uri (builder.Configuration["apiUrl"]) })
                .AddScoped<IHttpService, HttpService> ()
                .AddScoped<IAuthenticationService, AuthenticationService> ()
                .AddScoped<ILocalStorageService, LocalStorageService> ()
                .AddScoped<IMonthRepository, MonthRepository> ()
                .AddScoped<IBusPassportRepository, BusPassportRepository> ()
                .AddScoped<IPassportTypeRepository, PassportTypeRepository> ()
                .AddScoped<IBusPassPaymentRepository, BusPassPaymentRepository> ()
                .AddScoped<IYearRepository, YearRepository> ()
                .AddScoped<IUserRepository, UserRepository> ()
                .AddScoped<IMonthRepository, MonthRepository> ()
                .AddScoped<IAccountRepository, AccountRepository> ()
                .AddSyncfusionBlazor ()
                .AddBlazoredLocalStorage ();

            var host = builder.Build ();

            var authenticationService = host.Services.GetRequiredService<IAuthenticationService> ();
            await authenticationService.Initialize ();

            await host.RunAsync ();
        }
    }
}