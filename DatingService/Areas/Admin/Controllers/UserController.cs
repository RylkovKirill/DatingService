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

namespace DatingService.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;

        public UserController(UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
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

            return View(user);
        }

        public async Task<IActionResult> Edit(Guid? id)
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

            //ViewData["AvatarId"] = new SelectList(_context.Avatars, "Id", "Name", applicationUser.AvatarId);
            //ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", applicationUser.GenderId);

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FirstName,LastName,DateOfBirth,Latitude,Longitude,AvatarId,GenderId,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] ApplicationUser user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _userManager.UpdateAsync(user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationUserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["AvatarId"] = new SelectList(_context.Avatars, "Id", "Name", applicationUser.AvatarId);
            //ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", applicationUser.GenderId);
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
                await _emailSender.SendAsync(user.FullName, user.Email,  subject, htmlMessage);
                return RedirectToAction(nameof(List));
            }
            return View();
        }

        private bool ApplicationUserExists(Guid id)
        {
            return _userManager.Users.Any(e => e.Id == id);
        }
    }
}
