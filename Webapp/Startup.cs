using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebMarkupMin.AspNetCore3;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Features;
using Webapp.Helpers;
using BLL;

namespace Webapp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDataProtection()
                //.DisableAutomaticKeyGeneration()
                .SetDefaultKeyLifetime(TimeSpan.FromDays(14));
            #region session
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".dina.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(20);
                options.Cookie.IsEssential = true;
            });
            #endregion
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
            {
                option.LoginPath = "/Security/User/Login";
                option.AccessDeniedPath = "/AccessDenied";
                option.Cookie.Name = "User";
            });
            services.AddWebMarkupMin(options =>
            {
                options.AllowMinificationInDevelopmentEnvironment = false;
                options.AllowCompressionInDevelopmentEnvironment = false;
            })
              .AddHtmlMinification()
              .AddHttpCompression()
              .AddXmlMinification();
            services.AddResponseCaching();
            services.AddResponseCompression();
            services.AddMvc()
                 //.AddNewtonsoftJson()
                 .ConfigureApiBehaviorOptions(option =>
                 {
                     option.SuppressModelStateInvalidFilter = true;
                 }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddControllersWithViews()
                .AddSessionStateTempDataProvider();
            services.AddSession();
            string connectionString = Configuration.GetConnectionString("DinaServiceConnectionString");
            DinaServiceComponent.ConnectionString = connectionString;
            services.AddSession(options =>
            {
                options.Cookie.Name = "DinaServiceMessage";
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.IsEssential = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider svp)
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
            IHttpContextAccessor accessor = svp.GetService<IHttpContextAccessor>();
            MessageHandler.SetHttpContextAccessor(accessor);

            app.UseHttpsRedirection();
            app.UseStaticFiles(new StaticFileOptions()
            {

                HttpsCompression = HttpsCompressionMode.Compress,
                OnPrepareResponse = (context) =>
                {
                    var headers = context.Context.Response.GetTypedHeaders();
                    headers.CacheControl = new Microsoft.Net.Http.Headers.CacheControlHeaderValue
                    {
                        Public = true,
                        MaxAge = TimeSpan.FromDays(30)
                    };

                }
            });

            app.UseRouting();
            app.UseResponseCompression();
            app.UseWebMarkupMin();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.UseCookiePolicy();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
