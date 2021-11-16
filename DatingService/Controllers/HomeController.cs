using DatingService.Domain.Auth;
using DatingService.Models;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRequestService _requestService;

        private int indexUser;


        public HomeController(ILogger<HomeController> logger, IRequestService requestService, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _requestService = requestService;
            _userManager = userManager;
        }

        public async Task<IActionResult> IndexAsync()
        {
            //var userEmail = User.FindFirstValue(ClaimTypes.Email);
            //var users = _userManager.Users.ToList();
            //var usersWithoutAvatar = users.Where(x => x.AvatarId != null).ToList();
            //var userWithoutYou = usersWithoutAvatar.Where(x => x.Email != userEmail);

            //var user = usersWithoutAvatar[indexUser];
            //var ava = $"Files/Images/Avatars\\{user.Id}.png";
            //var birthday = user.DateOfBirth;
            //var age = DateTime.Today.Year - birthday.Year;
            //if (birthday.Date > DateTime.Today.AddYears(-age)) age--;
            //var viewModel = new CardsViewModel
            //{
            //    image = ava,
            //    userText = $"{user.FullName} {age}"
            //};
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var users = _userManager.Users;
            var friends = _requestService.GetUserFriends(user);
            return View(_requestService.GetPotentialFriends(users, friends));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
