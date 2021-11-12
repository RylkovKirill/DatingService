using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Persistence.Seeds
{
    public static class DefaultRoles
    {
        public static List<IdentityRole<Guid>> IdentityRoleList()
        {
            return new List<IdentityRole<Guid>>()
            {
                new IdentityRole<Guid>
                {
                    Id = Guid.Parse("4aa56c08-1cfc-46a5-a14c-d9ee66b22a04"),
                    Name = "SuperAdmin"
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.Parse("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                    Name = "Admin"
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.Parse("d821eb23-2337-4e31-a53d-fcec01900507"),
                    Name = "User"
                }
            };
        }
    }
}
