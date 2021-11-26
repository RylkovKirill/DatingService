using DatingService.Domain.Auth;
using DatingService.Infrastructure.ViewModels;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Controllers
{
    public class ChatController : Controller
    {
        private const int ChatCount = 4;

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
            var chats = filter == null ? _chatService.GetAll(user) : _chatService.GetAll(user).Where(c => c.Users.Any(u => u.FullName.ToUpper().Contains(filter.ToUpper())));
            var items = chats.Skip((page - 1) * ChatCount).Take(ChatCount).ToList();

            var viewModel = new ChatListViewModel()
            {
                Chats = items,
                PageViewModel = new PageViewModel(chats.Count(), page, ChatCount),
                SelectChat = id == null ? items.First() : items.Where(c => c.Id == id).First()
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
