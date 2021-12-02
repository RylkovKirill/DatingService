using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DatingService.TelegramBot.Services;
using Telegram.Bot;
using DatingService.Service.Services;
using DatingService.Service.Interfaces;
using DatingService.Service;
using DatingService.Persistence;
using Microsoft.EntityFrameworkCore;
using DatingService.Domain.Auth;
using Microsoft.AspNetCore.Identity;
using System;

namespace DatingService.TelegramBot
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            BotConfig = Configuration.GetSection("BotConfiguration").Get<BotConfiguration>();
        }

        public IConfiguration Configuration { get; }
        private BotConfiguration BotConfig { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

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

            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.MaxFailedAccessAttempts = 5;
            }).AddRoles<IdentityRole<Guid>>()
  .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddHostedService<ConfigureWebhook>();

            services.AddHttpClient("tgwebhook")
                   .AddTypedClient<ITelegramBotClient>(httpClient
                       => new TelegramBotClient(BotConfig.BotToken, httpClient));

            services.AddScoped<HandleUpdateService>();

            services.AddControllers()
                    .AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors();


            app.UseEndpoints(endpoints =>
            {
                var token = BotConfig.BotToken;
                endpoints.MapControllerRoute(name: "tgwebhook",
                                             pattern: $"bot/{token}",
                                             new { controller = "Webhook", action = "Post" });
                endpoints.MapControllers();
            });
        }
    }
}
