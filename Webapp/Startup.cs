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
using System.Security.Cryptography.X509Certificates;
using System.Net;

namespace Webapp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins, builder =>
                {
                    builder.WithOrigins("https://dinaservice.com",
                    "https://www.dinaservice.com");
                });
            });

            services.AddCertificateForwarding(options =>
            {
                options.CertificateHeader = "X-SSL-CERT";
                options.HeaderConverter = (headerValue) =>
                {
                    X509Certificate2 clientCertificate = null;

                    if (!string.IsNullOrWhiteSpace(headerValue))
                    {
                        byte[] bytes = StringToByteArray(headerValue);
                        clientCertificate = new X509Certificate2(bytes);
                    }

                    return clientCertificate;
                };
            });

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

            services.AddHsts(options =>
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(60);
                options.ExcludedHosts.Add("dinaservice.com");
                options.ExcludedHosts.Add("www.dinaservice.com");
                options.ExcludedHosts.Add("https://dinaservice.com");
                options.ExcludedHosts.Add("https://www.dinaservice.com");
            });

            services.AddHttpsRedirection(options =>
            {
                options.RedirectStatusCode = (int)HttpStatusCode.PermanentRedirect;
                options.HttpsPort = 443;
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
                app.UseStatusCodePagesWithReExecute("/error/{0}");
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
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
                context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                context.Response.Headers.Add("Strict-Transport-Security", "max-age=31536000; includeSubDomains");
                context.Response.Headers.Add("X-XSS-Protection", "1; mode=block");
                context.Response.Headers.Add("Referrer-Policy", "strict-origin");
                context.Response.Headers.Add("Permissions-Policy", "fullscreen=(self \"https://stablex.net\"), geolocation=*, camera=()");
                //context.Response.Headers.Add("Content-Security-Policy", "script-src https://dinaservice.com https://www.gstatic.com https://www.googletagmanager.com https://www.google.com https://localhost:44322;");
                await next();
            });
            app.UseRouting();
            app.UseCors();

            app.UseCertificateForwarding();
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

        private static byte[] StringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];

            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
    }
}
