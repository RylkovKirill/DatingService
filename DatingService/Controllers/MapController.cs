using DatingService.Domain.Auth;
using DatingService.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Controllers
{
    public class MapController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public MapController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public List<PlacemarkViewModel> GetMarks()
        {
            var users = _userManager.Users.Where(p => (p.Latitude != null && p.Longitude != null)).ToList();

            List<PlacemarkViewModel> markers = new List<PlacemarkViewModel>();

            foreach (var user in users)
            {
                markers.Add(
                    new PlacemarkViewModel
                    {
                        x = user.Latitude.Value,
                        y = user.Longitude.Value,
                        balloonCloseButton = true,
                        balloonContent = $"<div>" + user.Email + "</div>",
                        hideIconOnBalloonOpen = false,
                        preset = "islands#yellowStretchyIcon"
                    });
            }
            return markers;
        }
    }
}
