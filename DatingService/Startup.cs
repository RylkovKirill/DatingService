using DatingService.Domain.Auth;
using DatingService.Domain.Options;
using DatingService.Hubs;
using DatingService.Persistence;
using DatingService.Service;
using DatingService.Service.Interfaces;
using DatingService.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

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
            services.Configure<PostOptions>(Configuration.GetSection(nameof(PostOptions)));
            services.Configure<EmailOptions>(Configuration.GetSection(nameof(EmailOptions)));
            services.Configure<SmtpOptions>(Configuration.GetSection(nameof(SmtpOptions)));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.MaxFailedAccessAttempts = 5;
            }).AddRoles<IdentityRole<Guid>>()
              .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddControllersWithViews();
            services.AddAuthentication()
                       .AddGoogle(options =>
                        {
                            IConfigurationSection googleAuthNSection = Configuration.GetSection("Authentication:Google");
                            options.ClientId = "839535942443-pe0pp04bo6se855ovnmfec955nf89irh.apps.googleusercontent.com";
                            options.ClientSecret = "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";
                        });

            services.AddSingleton<IFileService, FileService>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IChatService, ChatService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IReportCategoryService, ReportCategoryService>();
            services.AddTransient<IReportService, ReportService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IBraintreeService, BraintreeService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IGenderService, GenderService>();

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
                endpoints.MapHub<CommentsHub>("/comments");
                endpoints.MapHub<MessagesHub>("/messages");
            });
        }
    }
}
