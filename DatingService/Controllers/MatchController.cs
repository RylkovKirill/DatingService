using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Domain.Enums;
using DatingService.Infrastructure.ViewModels;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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
        private int PageSize = 4;

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
            var items = friends.Skip((page - 1) * PageSize).Take(PageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, PageSize);

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

        public async Task<IActionResult> RemoveMatch(string Id)
        {
            var firstUser = await _userManager.GetUserAsync(HttpContext.User);
            if (firstUser == null)
            {
                return NotFound();
            }

            var secondUser = await _userManager.FindByIdAsync(Id);
            if (secondUser == null)
            {
                return NotFound();
            }

            var request = _requestService.Get(firstUser, secondUser);
            if (request == null)
            {
                return NotFound();
            }

            _requestService.Remove(request.Id);
            return RedirectToAction("List");
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
