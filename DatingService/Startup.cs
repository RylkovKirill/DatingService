using DatingService.Domain.Auth;
using DatingService.Domain.Options;
using DatingService.Hubs;
using DatingService.Persistence;
using DatingService.Service;
using DatingService.Service.Interfaces;
using DatingService.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService
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
            services.Configure<AvatarOptions>(Configuration.GetSection(nameof(AvatarOptions)));
            services.Configure<EmailOptions>(Configuration.GetSection(nameof(EmailOptions)));
            services.Configure<SmtpOptions>(Configuration.GetSection(nameof(SmtpOptions)));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            services.AddAuthentication()
                   /* .AddGoogle(options =>
                    {
                        IConfigurationSection googleAuthNSection = Configuration.GetSection("Authentication:Google");
                        options.ClientId = googleAuthNSection["ClientId"];
                        options.ClientSecret = googleAuthNSection["ClientSecret"];
                    })*/;

            services.AddSingleton<IFileService, FileService>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped(typeof(Service.IRepository<>), typeof(Repository<>));
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IChatService, ChatService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IAvatarRepository, AvatarRepository>();

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSignalR(hubOptions =>
            {
                hubOptions.EnableDetailedErrors = true;
                hubOptions.KeepAliveInterval = TimeSpan.FromSeconds(15);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-EN"),
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Users}/{action=List}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
                endpoints.MapRazorPages();
                endpoints.MapHub<MessagesHub>("/messages");
            });
        }
    }
}
