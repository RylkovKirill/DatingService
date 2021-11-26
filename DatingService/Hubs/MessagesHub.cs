using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Hubs
{
    public class MessagesHub : Hub
    {
        private readonly IChatService _chatService;
        private readonly IMessageService _messageService;

        private readonly UserManager<ApplicationUser> _userManager;

        public MessagesHub(
            IMessageService messageService,
            UserManager<ApplicationUser> userManager,
            IChatService chatService)
        {
            _messageService = messageService;
            _userManager = userManager;
            _chatService = chatService;
        }

        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task SendMessage(string chatId, string content)
        {
            var user = await _userManager.GetUserAsync(Context.User);

            var message = new Message
            {
                ChatId = Guid.Parse(chatId),
                UserId = user.Id,
                User = user,
                Content = content
            };

            var chat = _chatService.Get(Guid.Parse(chatId));
            chat.DateUpdated = DateTime.UtcNow;
            _chatService.Update(chat);

            _messageService.Add(message);
            await Clients.Group(chatId).SendAsync("Send", user.UserName, message.Content, message.DateCreated.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds);
        }
    }
}
