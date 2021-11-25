using DatingService.Domain.Auth;
using DatingService.Infrastructure.ViewModels;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Controllers
{
    [Authorize]
    public class MapController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRequestService _requestService;

        public MapController(
            UserManager<ApplicationUser> userManager,
            IRequestService requestService)
        {
            _userManager = userManager;
            _requestService = requestService;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public async Task<List<PlacemarkViewModel>> GetMarks()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var users = _requestService.GetUserFriends(user).Where(p => (p.Latitude != null && p.Longitude != null)).ToList();

            List<PlacemarkViewModel> markers = new();

            foreach (var items in users)
            {
                markers.Add(
                    new PlacemarkViewModel
                    {
                        x = items.Latitude.Value,
                        y = items.Longitude.Value,
                        balloonCloseButton = true,
                        balloonContent = $"<a href='Match/Details/{items.Id}'>{items.Email}</a>",
                        hideIconOnBalloonOpen = false,
                        preset = "islands#yellowStretchyIcon"
                    });
            }
            return markers;
        }
    }
}
