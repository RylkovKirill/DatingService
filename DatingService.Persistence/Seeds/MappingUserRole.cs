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
                    RoleId = Guid.Parse("67397b47-b0e9-4e15-8b82-57c0884af92c"),
                    UserId = Guid.Parse("c6dd1e20-cce1-4299-be0c-862a2b681039")
                }
            };
        }
    }
}
