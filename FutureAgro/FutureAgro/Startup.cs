using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Services;
using FutureAgro.Web.Hubs;
using Lamar;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR;
using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Contratos;
using FutureAgro.IoT.Emuladores;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.Web.Services;

namespace FutureAgro.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public static IHubContext<FutureAgroHub> FutureAgroHub { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureContainer(ServiceRegistry services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            
            services.AddDbContext<FutureAgroIdentityDbContext>(options =>
                   options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

            services.AddIdentityCore<IdentityUser>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;
            })
                .AddDefaultTokenProviders()
                .AddSignInManager()
                .AddEntityFrameworkStores<FutureAgroIdentityDbContext>();
            
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
                options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            })
            .AddCookie(cookieOptions =>
            {
                cookieOptions.AccessDeniedPath = "/Account/Login";
                cookieOptions.LoginPath = "/Account/Login";
                cookieOptions.LogoutPath = "/Account/Login";
            })

            /*B-AddsAutenticar*/

            .AddIdentityCookies();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/Login";
                options.LogoutPath = "/Account/Login";
                options.SlidingExpiration = true;
            });

            services.AddSignalR(options =>
            {
                //options.EnableDetailedErrors = true;
            });

            // Also exposes Lamar specific registrations
            // and functionality
            services.Scan(s =>
            {
                s.AssembliesAndExecutablesFromApplicationBaseDirectory();
                s.WithDefaultConventions();
            });

            /*B-InyeccionServicios*/
            

            services.AddSingleton<ILector, LectorCrecimiento>();
            services.AddSingleton<ILector, LectorPlantasMuertas>();
            services.AddTransient<PlantasRepository>();
            services.AddSingleton<ServicioCrecimiento>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            
            app.UseSignalR(config =>
            {
                config.MapHub<FutureAgroHub>("/futureagrohub");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            

            FutureAgroHub = app.ApplicationServices.GetService<IHubContext<FutureAgroHub>>();


            /*B-InicializarServicios*/

            var serviceCrecimiento = app.ApplicationServices.GetService<ServicioCrecimiento>();
            var servicePlantasMuertas = app.ApplicationServices.GetService<ServicioPlantasMuertas>();
        }
    }
}
