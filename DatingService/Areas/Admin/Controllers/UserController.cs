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
        public const int PageSize = 10;

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

        public async Task<IActionResult> ListAsync(int page = 1, string filter = null)
        {
            var orders = filter == null ? _userManager.Users : _userManager.Users.Where(p => p.FirstName.ToUpper().Contains(filter.ToUpper()));

            var count = await orders.CountAsync();
            var items = await orders.Skip((page - 1) * PageSize).Take(PageSize).ToListAsync();

            var pageViewModel = new PageViewModel(count, page, PageSize);
            var viewModel = new UserListViewModel
            {
                Filter = filter,
                PageViewModel = pageViewModel,
                Users = items
            };

            return View(viewModel);
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
                return RedirectToAction("List");
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

        [HttpPost("[area]/[controller]/Delete/{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            await _userManager.DeleteAsync(user);

            return Ok();
        }
    }
}
