using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Persistence.Configs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatingService.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Comment> Comments { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfig());
            builder.ApplyConfiguration(new AvatarConfig());
            builder.ApplyConfiguration(new GenderConfig());
            builder.ApplyConfiguration(new PostConfig());
            builder.ApplyConfiguration(new ImageConfig());
            builder.ApplyConfiguration(new CommentConfig());

            base.OnModelCreating(builder);
        }
    }
}
