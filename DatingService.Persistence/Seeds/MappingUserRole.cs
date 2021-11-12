using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Persistence.Seeds
{
    public static class MappingUserRole
    {
        public static List<IdentityUserRole<Guid>> IdentityUserRoleList()
        {
            return new List<IdentityUserRole<Guid>>()
            {
                new IdentityUserRole<Guid>
                {
                    RoleId = Guid.Parse("4aa56c08-1cfc-46a5-a14c-d9ee66b22a04"),
                    UserId = Guid.Parse("8e034e7e-7424-4dea-94b7-0ce34a160bef")
                }
            };
        }
    }
}
