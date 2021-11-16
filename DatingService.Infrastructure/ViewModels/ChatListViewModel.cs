using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Infrastructure.ViewModels
{
    public class ChatListViewModel
    {
        public List<Chat> Chats { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
