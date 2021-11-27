using DatingService.Domain.Auth;
using DatingService.Persistence;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Tests
{
    public static class UserHelper
    {
        public static ApplicationUser AddUser(ApplicationDbContext applicationDbContext)
        {
            ApplicationUser user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                UserName = "user",
                Email = "email",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "password"),
            };
            applicationDbContext.Users.Add(user);
            applicationDbContext.SaveChanges();
            return user;
        }
    }
}
