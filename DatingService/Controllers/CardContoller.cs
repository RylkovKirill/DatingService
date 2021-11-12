using DatingService.Domain.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingService.Infrastructure.ViewModels;

using System.Security.Claims;

namespace DatingService.Controllers
{
    public class CardController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private int indexUser;
        public CardController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            indexUser = 0;
        }
        public IActionResult Index()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            var users = _userManager.Users.ToList();
            var usersWithoutAvatar = users.Where(x => x.AvatarId != null).ToList();
            var userWithoutYou = usersWithoutAvatar.Where(x => x.Email != userEmail);

            var user = usersWithoutAvatar[indexUser];
            var ava = $"Files/Images/Avatars\\{user.Id}.png";
            var birthday = user.DateOfBirth;
            var age = DateTime.Today.Year - birthday.Year;
            if (birthday.Date > DateTime.Today.AddYears(-age)) age--;
            var viewModel = new CardsViewModel
            {
                image = ava,
                userText = $"{user.FullName} {age}"
            };
            return View(viewModel);
        }
    }
}