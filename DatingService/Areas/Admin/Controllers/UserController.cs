using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DatingService.Domain.Auth;
using Microsoft.AspNetCore.Identity;
using DatingService.Service.Interfaces;
using System.Net.Mail;
using DatingService.Infrastructure.ViewModels;

namespace DatingService.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly IReportService _reportService;

        private readonly IPostService _postService;


        public UserController(UserManager<ApplicationUser> userManager,
                              RoleManager<IdentityRole<Guid>> roleManager,
                              IEmailSender emailSender,
                              IReportService reportService,
                              IPostService postService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _reportService = reportService;
            _postService = postService;
        }

        [Route("[area]")]
        [Route("[area]/Users")]
        [Route("[area]/Users/[action]")]
        public IActionResult List()
        {
            var users = _userManager.Users;

            return View(users);
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id.Value.ToString());
            if (user == null)
            {
                return NotFound();
            }

            user.Posts = await _postService.GetAll(user).ToListAsync();

            return View(user);
        }

        // GET: Admin/User/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id.Value.ToString());
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            var message = new MailMessage();
            return View(message);
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Guid Id, string subject, string htmlMessage)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(Id.ToString());
                await _emailSender.SendAsync(user.FullName, user.Email, subject, htmlMessage);
                return RedirectToAction(nameof(List));
            }
            return View();
        }

        private bool ApplicationUserExists(Guid id)
        {
            return _userManager.Users.Any(e => e.Id == id);
        }

        [HttpGet]
        public async Task<IActionResult> Lock(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            user.SentReports = await _reportService.GetAll(user).ToListAsync();
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> UserRoles(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }
            var userRoles = await _userManager.GetRolesAsync(user);
            var vewModel = new UserRolesViewModel
            {
                Id = user.Id,
                Roles = userRoles.ToList(),
                PotentialRoles = _roleManager.Roles.Where(r => !userRoles.ToList().Contains(r.Name)).ToList()
            };
            return View(vewModel);
        }

        public async Task<IActionResult> AddRoleAsync(Guid id, Guid roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId.ToString());
            if (role == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            await _userManager.AddToRoleAsync(user, role.Name);

            return RedirectToAction(nameof(UserRoles), new { id });
        }

        [HttpPost("[area]/[controller]/RemoveRole/{id:guid}")]
        public async Task<IActionResult> RemoveRoleAsync(Guid id, [FromBody] string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            await _userManager.RemoveFromRoleAsync(user, role.Name);

            return Ok();
        }
    }
}
