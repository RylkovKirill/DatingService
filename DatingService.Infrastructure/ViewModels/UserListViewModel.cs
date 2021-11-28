using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using System.Collections.Generic;

namespace DatingService.Infrastructure.ViewModels
{
    public class UserListViewModel
    {
        public string Filter { get; set; }
        public PageViewModel PageViewModel { get; set; }

        public List<ApplicationUser> Users { get; set; }
    }
}
