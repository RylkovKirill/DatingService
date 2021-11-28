using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DatingService.Infrastructure.ViewModels
{
    public class UserRolesViewModel
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }

        public List<string> Roles { get; set; }
        public List<IdentityRole<Guid>> PotentialRoles { get; set; }
    }
}
