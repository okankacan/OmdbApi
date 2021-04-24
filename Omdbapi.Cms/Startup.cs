using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Omdbapi.Cms.IdentityCore;
using Omdbapi.Core.Contexts;
using Omdbapi.Core.Helpers;
using Omdbapi.Core.Interface.Base;
using Omdbapi.Infrastructure.Base;
using Omdbapi.InfraStructure;
 
namespace Omdbapi.Cms
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
 
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.Configure<PasswordHasherOptions>(options => options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Account/Login";
                options.LogoutPath = $"/Account/Logout";
                options.AccessDeniedPath = $"/AccessDenied";
            });

   
            services.AddDbContext<BaseDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    sqlServerOptions => sqlServerOptions.CommandTimeout(32767)));

            services.AddDbContext<OmdbApiDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<OmdbApiDBContext>()
                .AddDefaultTokenProviders();

            ScopeService(services);

            AddSingletonService(services);
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            });

            services.AddMemoryCache();
            services.AddSession();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                builder =>
                {
                    builder.WithOrigins("https://localhost:44390")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
            });

        }

        private void AddSingletonService(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(new HttpClient() { Timeout = TimeSpan.FromDays(1) });

        }

        private void ScopeService(IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped(typeof(IBaseGenericRepository<,,>), typeof(BaseGenericRepository<,,>));
         }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            ServiceGetter.SetAccessor(httpContextAccessor);
             app.UseCors();

            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
