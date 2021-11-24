using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DatingService.Persistence.Seeds
{
    public static class MappingUserRoles
    {
        public static List<IdentityUserRole<Guid>> GetUserRoles()
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
