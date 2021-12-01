using System.Threading.Tasks;
using DatingService.Domain.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DatingService.Service.Interfaces;
using Microsoft.Extensions.Options;
using DatingService.Domain.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;

namespace DatingService.Areas.Identity.Pages.Account.Manage
{
    public class AvatarModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AvatarOptions _avatarOptions;
        private readonly IFileService _fileService;
        private readonly IWebHostEnvironment _environment;

        public AvatarModel(
            UserManager<ApplicationUser> userManager,
            IFileService fileService,
            IOptions<AvatarOptions> avatarOptions,
            IWebHostEnvironment environment)
        {
            _userManager = userManager;
            _avatarOptions = avatarOptions.Value;
            _fileService = fileService;
            _environment = environment;
        }

        [TempData]
        public string StatusMessage { get; set; }


        [BindProperty]
        public string AvatarPath { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (user.AvatarPath != null)
            {
                AvatarPath = Path.Combine(_avatarOptions.Path, user.AvatarPath);
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile file)
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

            if (file == null)
            {
                return Page();
            }

            var fileName = user.Id + "-" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + Path.GetExtension(file.FileName);

            if (user.AvatarPath != null)
            {
                _fileService.Delete(Path.Combine(_environment.WebRootPath, _avatarOptions.Path, user.AvatarPath));
            }

            var path = Path.Combine(_environment.WebRootPath, _avatarOptions.Path, fileName);
            _fileService.Save(file, path);


            user.AvatarPath = fileName;

            var updateAvatarResult = await _userManager.UpdateAsync(user);
            if (!updateAvatarResult.Succeeded)
            {
                StatusMessage = "Unexpected error when trying to set avatar.";
                return RedirectToPage();
            }

            StatusMessage = "Your avatar has been updated";
            return RedirectToPage();
        }
    }
}
