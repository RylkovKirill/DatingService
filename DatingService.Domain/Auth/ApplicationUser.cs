using DatingService.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DatingService.Domain.Auth
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PostCount { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string AvatarPath { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Guid? GenderId { get; set; }

        public Gender Gender { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public ICollection<Chat> Chats { get; set; }
        public ICollection<Message> Messages { get; set; }

        public ICollection<Request> SentRequests { get; set; }
        public ICollection<Request> ReceivedRequests { get; set; }

        public ICollection<Report> SentReports { get; set; }
        public ICollection<Report> ReceivedReports { get; set; }
    }
}
