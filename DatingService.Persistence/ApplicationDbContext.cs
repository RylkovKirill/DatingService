using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Persistence.Configs;
using DatingService.Persistence.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatingService.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ReportCategory> ReportCategory { get; set; }
        public DbSet<Report> Reports { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfig());
            builder.ApplyConfiguration(new GenderConfig());
            builder.ApplyConfiguration(new PostConfig());
            builder.ApplyConfiguration(new ImageConfig());
            builder.ApplyConfiguration(new CommentConfig());
            builder.ApplyConfiguration(new ChatConfig());
            builder.ApplyConfiguration(new MessageConfig());
            builder.ApplyConfiguration(new RequestConfig());
            builder.ApplyConfiguration(new ReportCategoryConfig());
            builder.ApplyConfiguration(new ReportConfig());
            builder.ApplyConfiguration(new OrderConfig());

            builder.Seed();

            base.OnModelCreating(builder);
        }
    }
}
