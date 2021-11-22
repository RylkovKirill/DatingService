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

namespace DatingService.Areas.Identity.Pages.Account.Manage
{
    public class AvatarModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AvatarOptions _avatarOptions;
        private readonly IFileService _fileService;
        private readonly IWebHostEnvironment _environment;
        private readonly IAvatarRepository _avatarRepository;

        public AvatarModel(
            UserManager<ApplicationUser> userManager,
            IFileService fileService,
            IOptions<AvatarOptions> avatarOptions,
            IWebHostEnvironment environment,
            IAvatarRepository avatarRepository)
        {
            _userManager = userManager;
            _avatarOptions = avatarOptions.Value;
            _fileService = fileService;
            _environment = environment;
            _avatarRepository = avatarRepository;
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

            if (user.AvatarId != null)
            {
                var avatar = _avatarRepository.GetByUserId(user.Id);
                AvatarPath = Path.Combine(_avatarOptions.Path, avatar.Path);
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

            var fileName = user.Id + Path.GetExtension(file.FileName);
            var path = Path.Combine(_environment.WebRootPath, _avatarOptions.Path, fileName);
            _fileService.Save(file, path);

            var avatar = _avatarRepository.GetByUserId(user.Id);
            if (avatar == null)
            {
                avatar = new Avatar();
            }

            avatar.Name = user.UserName;
            avatar.Path = fileName;
            avatar.UserId = user.Id;

            user.Avatar = avatar;

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
