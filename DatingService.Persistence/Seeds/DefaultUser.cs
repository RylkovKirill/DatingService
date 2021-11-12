using DatingService.Domain.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Persistence.Seeds
{
    public static class DefaultUser
    {
        public static List<ApplicationUser> IdentityBasicUserList()
        {
            return new List<ApplicationUser>()
            {
                new ApplicationUser
                {
                    Id = Guid.Parse("8e034e7e-7424-4dea-94b7-0ce34a160bef"),
                    UserName = "superadmin",
                    Email = "superadmin@gmail.com",
                    FirstName = "SuperAdmin",
                    LastName = "SuperAdmin",
                    EmailConfirmed = true,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "SUPERADMIN@GMAIL.COM",
                    NormalizedUserName="SUPERADMIN"
                },
                new ApplicationUser
                {
                    Id = Guid.Parse("5f7578c4-3946-4f25-a8c5-dcdc4f77a06d"),
                    UserName = "user",
                    Email = "user@gmail.com",
                    FirstName = "User",
                    LastName = "User",
                    EmailConfirmed = true,
                    // Password@123
                    PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                    NormalizedEmail= "USER@GMAIL.COM",
                    NormalizedUserName="USER"
                },
            };
        }
    }
}
