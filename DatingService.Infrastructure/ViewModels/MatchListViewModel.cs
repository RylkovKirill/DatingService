using DatingService.Domain.Auth;
using System.Collections.Generic;


namespace DatingService.Infrastructure.ViewModels
{
    public class MatchListViewModel
    {
        public string Filter { get; set; }

        public List<ApplicationUser> Matches { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
