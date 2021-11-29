using DatingService.Domain.Auth;
using DatingService.Infrastructure.ViewModels;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private const int PageSize = 4;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IChatService _chatService;
        private readonly IMessageService _messageService;

        public ChatController(
            UserManager<ApplicationUser> userManager,
            IChatService chatService,
            IMessageService messageService)
        {
            _userManager = userManager;
            _chatService = chatService;
            _messageService = messageService;
        }

        public async Task<IActionResult> ListAsync(Guid? id, int page = 1, string filter = null)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var chats = filter == null ? _chatService.GetAll(user) : _chatService.GetAll(user).ToList().Where(c => c.Users.Any(u => u != user && u.FullName.ToUpper().Contains(filter.ToUpper())));

            var count = chats.Count();
            var items = chats.Skip((page - 1) * PageSize).Take(PageSize).ToList();

            var pageViewModel = new PageViewModel(count, page, PageSize);

            var selectChat = items.Count == 0 ? null : id == null ? items.First() : chats.Where(c => c.Id == id).First();
            if (selectChat != null)
            {
                selectChat.DateUpdated = DateTime.Now;
                _chatService.Update(selectChat);
            }

            var viewModel = new ChatListViewModel()
            {
                Chats = items,
                PageViewModel = pageViewModel,
                SelectChat = selectChat,
                Filter = filter
            };

            return View(viewModel);
        }

        public IActionResult Details(Guid id)
        {
            var chat = _chatService.Get(id);
            if (chat == null)
            {
                return NotFound();
            }
            chat.Messages = _messageService.GetAll(chat).ToList();
            return View(chat);
        }
    }
}
