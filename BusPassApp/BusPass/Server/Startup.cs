using BusPass.Server.Repository;
using BusPass.Server.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace BusPass.Server {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices (IServiceCollection services) {
            services.AddCors ();

            services.AddDbContext<ApplicationDbContext> (x => x.UseSqlite (Configuration.GetConnectionString ("DefaultConnection")));

            //Repository injection
            services.AddScoped<IUserRepository, UserRepository> ();
            services.AddScoped<IAccountRepository, AccountRepository> ();
            services.AddScoped<IPassTypeRepository, PassTypeRepository> ();
            services.AddScoped<IBusPassportRepository, BusPassportRepository> ();

            //Services injection
            services.AddScoped<IUserService, UserService> ();
            services.AddScoped<IAccountService, AccountService> ();
            services.AddScoped<IPassTypeService, PassTypeService> ();
            services.AddScoped<IBusPassportService, BusPassportService> ();

            services.AddControllersWithViews ();
            // .AddNewtonsoftJson (options =>
            //     options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            // );

            services.AddRazorPages ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
                app.UseWebAssemblyDebugging ();
            } else {
                app.UseExceptionHandler ("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }

            app.UseCors (
                options => options
                .AllowAnyOrigin ()
                .AllowAnyMethod ()
                .AllowAnyHeader ()
            );

            app.UseHttpsRedirection ();
            app.UseBlazorFrameworkFiles ();
            app.UseStaticFiles ();

            app.UseRouting ();

            app.UseEndpoints (endpoints => {
                endpoints.MapRazorPages ();
                endpoints.MapControllers ();
                endpoints.MapFallbackToFile ("index.html");
            });
        }
    }
}