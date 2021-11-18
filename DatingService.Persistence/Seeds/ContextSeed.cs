using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DatingService.Persistence.Seeds
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            CreateRoles(modelBuilder);
            CreateGenders(modelBuilder);
            CreateBasicUsers(modelBuilder);
            CreateReportCategories(modelBuilder);
            MapUserRole(modelBuilder);
        }

        private static void CreateReportCategories(ModelBuilder modelBuilder)
        {
            List<ReportCategory> roles = DefaultReportCategory.ReportCategoryList();
            modelBuilder.Entity<ReportCategory>().HasData(roles);
        }

        private static void CreateRoles(ModelBuilder modelBuilder)
        {
            List<IdentityRole<Guid>> roles = DefaultRoles.IdentityRoleList();
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(roles);
        }
        private static void CreateGenders(ModelBuilder modelBuilder)
        {
            List<Gender> genders = DefaultGenders.IdentityGenderList();
            modelBuilder.Entity<Gender>().HasData(genders);
        }

        private static void CreateBasicUsers(ModelBuilder modelBuilder)
        {
            List<ApplicationUser> users = DefaultUsers.IdentityBasicUserList();
            modelBuilder.Entity<ApplicationUser>().HasData(users);
        }

        private static void MapUserRole(ModelBuilder modelBuilder)
        {
            var identityUserRoles = MappingUserRole.IdentityUserRoleList();
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(identityUserRoles);
        }
    }
}
