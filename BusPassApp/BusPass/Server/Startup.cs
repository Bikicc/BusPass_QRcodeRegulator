using System.Text;
using BusPass.Server.HelperClasses;
using BusPass.Server.Repository;
using BusPass.Server.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
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

            var appSettingsSection = Configuration.GetSection ("AppSettings");
            services.Configure<AppSettings> (appSettingsSection);

            services.AddDbContext<ApplicationDbContext> (x => x.UseSqlite (Configuration.GetConnectionString ("DefaultConnection")));

            var appSettings = appSettingsSection.Get<AppSettings> ();
            var key = Encoding.ASCII.GetBytes (appSettings.Secret);
            services.AddAuthentication (x => {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer (x => {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey (key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            //Repository injection
            services.AddScoped<IUserRepository, UserRepository> ();
            services.AddScoped<IAccountRepository, AccountRepository> ();
            services.AddScoped<IPassTypeRepository, PassTypeRepository> ();
            services.AddScoped<IBusPassportRepository, BusPassportRepository> ();
            services.AddScoped<IBusPassPaymentRepository, BusPassPaymentRepository> ();

            //Services injection
            services.AddScoped<IUserService, UserService> ();
            services.AddScoped<IAccountService, AccountService> ();
            services.AddScoped<IPassTypeService, PassTypeService> ();
            services.AddScoped<IBusPassportService, BusPassportService> ();
            services.AddScoped<IBusPassPaymentService, BusPassPaymentService> ();
            services.AddHostedService<CronService> ();

            services.AddControllersWithViews ()
            .AddNewtonsoftJson (options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

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

            // app.UseMiddleware<JwtMiddleware> ();

            app.UseHttpsRedirection ();
            app.UseBlazorFrameworkFiles ();
            app.UseStaticFiles ();

            app.UseRouting ();

            app.UseAuthentication ();
            app.UseAuthorization ();

            app.UseEndpoints (endpoints => {
                endpoints.MapRazorPages ();
                endpoints.MapControllers ();
                endpoints.MapFallbackToFile ("index.html");
            });
        }
    }
}