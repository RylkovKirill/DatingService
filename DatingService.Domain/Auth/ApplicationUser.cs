﻿using Microsoft.AspNetCore.Identity;
using System;

namespace DatingService.Domain.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime DateOfBirth { get; set; }

        public Guid GenderId { get; set; }
    }
}
