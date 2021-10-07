using DatingService.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;

namespace DatingService.Domain.Auth
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public DateTime DateOfBirth { get; set; }

        public Guid? AvatarId { get; set; }
        public Guid? GenderId { get; set; }

        public Avatar Avatar { get; set; }
        public Gender Gender { get; set; }
    }
}
