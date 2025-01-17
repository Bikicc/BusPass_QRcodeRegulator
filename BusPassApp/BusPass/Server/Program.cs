﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
namespace BusPass.Server {
    public class Program {
        public static void Main (string[] args) {

            // CreateHostBuilder (args).Build ().Run ();

            BuildWebHost (args).Run ();
        }

        // public static IHostBuilder CreateHostBuilder (string[] args) =>
        //     Host.CreateDefaultBuilder (args)
        //     .ConfigureWebHostDefaults (webBuilder => {
        //         webBuilder.UseStartup<Startup> ();
        //     });

        public static IWebHost BuildWebHost (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .UseConfiguration (new ConfigurationBuilder ()
                .AddJsonFile ("appsettings.json", optional : false, reloadOnChange : true)
                .AddCommandLine (args)
                .Build ())
            .UseStartup<Startup> ()
            .Build ();
    }
}