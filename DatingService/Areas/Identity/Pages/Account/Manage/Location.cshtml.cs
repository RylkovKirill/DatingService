using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DatingService.Domain.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System;
using System.Globalization;

namespace DatingService.Areas.Identity.Pages.Account.Manage
{
    public class LocationModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public LocationModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "Latitude")]
            public double Latitude { get; set; }

            [Display(Name = "Longitude")]
            public double Longitude { get; set; }
        }

        private void Load(ApplicationUser user)
        {
            Input = new InputModel
            {
                Latitude = user.Latitude.Value,
                Longitude = user.Longitude.Value
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            Load(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            user.Latitude = Input.Latitude;
            user.Longitude = Input.Longitude;

            var updateAvatarResult = await _userManager.UpdateAsync(user);
            if (!updateAvatarResult.Succeeded)
            {
                StatusMessage = "Unexpected error when trying to set location.";
                return RedirectToPage();
            }

            StatusMessage = "Your location has been updated";
            return RedirectToPage();
        }
    }
}
