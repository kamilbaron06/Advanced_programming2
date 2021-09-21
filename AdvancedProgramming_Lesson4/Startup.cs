using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Hubs;
using Microsoft.AspNetCore.Localization;
using AdvancedProgramming_Lesson4.Middlewares;
using System.Globalization;

using Microsoft.Extensions.Options;





namespace AdvancedProgramming_Lesson4
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

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
                services.AddDbContext<ApplicationDbContext2>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddLocalization(options =>
            {
                options.ResourcesPath = "Resources";
            });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.SetDefaultCulture("en-Us");
                options.AddSupportedUICultures("en-US", "de-DE", "pl-PL");
                options.FallBackToParentUICultures = true;

                options
                     .RequestCultureProviders
                     .Remove(typeof(AcceptLanguageHeaderRequestCultureProvider));
            });

            services
                .AddRazorPages()
                .AddViewLocalization();


            services.AddScoped<RequestLocalizationCookiesMiddleware>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRequestLocalization();

            // will remember to write the cookie 
            app.UseRequestLocalizationCookies();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                
            });
        }
    }
}
