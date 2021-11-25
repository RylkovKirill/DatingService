using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Domain.Enums;
using DatingService.Infrastructure.ViewModels;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Controllers
{
    public class MatchController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRequestService _requestService;
        private readonly IChatService _chatService;
        private readonly IMessageService _messageService;
        private readonly IPostService _postService;
        private readonly IReportService _reportService;
        private readonly IReportCategoryService _reportCategoryService;
        private readonly IGenderService _genderService;
        private int pageSize = 10;

        public MatchController(UserManager<ApplicationUser> userManager,
                                IRequestService requestService,
                                IChatService chatService,
                                IMessageService messageService,
                                IPostService postService,
                                IReportService reportService,
                                 IReportCategoryService reportCategoryService,
                                 IGenderService genderService)
        {
            _userManager = userManager;
            _requestService = requestService;
            _chatService = chatService;
            _messageService = messageService;
            _postService = postService;
            _reportService = reportService;
            _reportCategoryService = reportCategoryService;
            _genderService = genderService;
        }

        public async Task<IActionResult> ListAsync(int page = 1, string filter = null)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }

            var friends = _requestService.GetUserFriends(user).ToList();

            if (filter != null)
            {
                friends = friends.Where(p => p.FullName.ToUpper().Contains(filter.ToUpper())).ToList();
            }

            var count = friends.Count();
            var items = friends.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);

            var friendsViewModel = new MatchListViewModel()
            {
                Matches = items,
                PageViewModel = pageViewModel,
            };
            return View(friendsViewModel);
        }

        public async Task<IActionResult> DetailsAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            if (user.GenderId != null)
            {
                user.Gender = _genderService.Get(user.GenderId.Value);
            }

            user.Posts = await _postService.GetAll(user).ToListAsync();
            return View(user);
        }

        public async Task<IActionResult> UsersAsync(int page = 1)
        {

            var user = await _userManager.GetUserAsync(HttpContext.User);
            var users = _userManager.Users.Where(u => u != user).Include(u => u.Gender).ToList();
            var count = users.Count();
            var items = users.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var pageViewModel = new PageViewModel(count, page, pageSize);
            var usersViewModel = new UsersViewModel()
            {
                Users = items,
                Friends = _requestService.GetUserFriends(user).ToList(),
                PageViewModel = pageViewModel,
            };
            return View(usersViewModel);
        }

        public async Task<IActionResult> RequestsAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var requestsViewModel = new RequestViewModel()
            {
                OutgoingRequests = _requestService.GetAllOutgoingByUser(user),
                IncomingRequests = _requestService.GetAllIncomingByUser(user),
            };
            return View(requestsViewModel);
        }

        public async Task<IActionResult> AddToFriendsAsync(string userId)
        {
            if (!_requestService.IsRequestExistence(await _userManager.GetUserAsync(HttpContext.User), await _userManager.FindByIdAsync(userId)))
            {
                var request = new Request()
                {
                    ReceiverId = Guid.Parse(userId),
                    Sender = await _userManager.GetUserAsync(HttpContext.User),
                };
                _requestService.Update(request);
            }
            return RedirectToAction("Users");
        }

        public IActionResult ChangeRequest(Guid requestId, bool confirmed)
        {
            var request = _requestService.Get(requestId);
            if (confirmed == true)
            {
                request.RequestStatus = RequestStatus.Accepted;
                _requestService.Update(request);
            }
            else
            {
                _requestService.Remove(request.Id);
            }
            return RedirectToAction("Requests");
        }

        public async Task<IActionResult> ChatAsync(string userId)
        {
            var user1 = await _userManager.GetUserAsync(HttpContext.User);
            var user2 = _userManager.FindByIdAsync(userId).Result;
            var chat = _chatService.Get(user1, user2);
            if (chat == default)
            {
                chat = new Chat()
                {
                    Users = new List<ApplicationUser> { user1, user2 }
                };
                _chatService.Update(chat);
            }
            chat.Messages = _messageService.GetAll(chat).ToList();
            return View(chat);
        }

        [HttpGet]
        public IActionResult CreateReport(Guid userId)
        {
            var report = new Report
            {
                ReceiverId = userId
            };

            ViewBag.ReportCategories = new SelectList(_reportCategoryService.GetAll(), "Id", "Name");

            return View(report);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReport(Report report)
        {
            //var post = _postService.Get(id);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            report.SenderId = user.Id;
            //var report = _reportService.Get(user, post);

            //if (report == null)
            //{
            //    report = new Report
            //    {
            //        Post = post,
            //        User = user,
            //    };
            //}
            //report.CategoryId = reportCategoryId;

            _reportService.Add(report);
            return RedirectToAction("List");
        }
    }
}
