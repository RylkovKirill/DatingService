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
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Avatar> Avatars { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfig());
            builder.ApplyConfiguration(new GenderConfig());
            builder.ApplyConfiguration(new FileConfig<Avatar>());
            base.OnModelCreating(builder);
        }
    }
}
