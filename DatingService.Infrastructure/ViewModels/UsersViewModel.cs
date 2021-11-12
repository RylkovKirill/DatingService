using DatingService.Domain.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Infrastructure.ViewModels
{
    public class UsersViewModel
    {
        public List<ApplicationUser> Users { get; set; }
        public List<ApplicationUser> Friends { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
