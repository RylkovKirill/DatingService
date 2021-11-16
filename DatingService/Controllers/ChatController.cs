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
        private const int ChatCount = 10;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IChatService _chatService;
        private readonly IMessageService _messageService;

        public ChatController(UserManager<ApplicationUser> userManager,
                              IChatService chatService,
                              IMessageService messageService)
        {
            _userManager = userManager;
            _chatService = chatService;
            _messageService = messageService;
        }

        public async Task<IActionResult> ListAsync(int page = 1)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var chats = _chatService.GetAll(user);

            var viewModel = new ChatListViewModel()
            {
                Chats = chats.Skip((page - 1) * ChatCount).Take(ChatCount).ToList(),
                PageViewModel = new PageViewModel(chats.Count(), page, ChatCount)
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
