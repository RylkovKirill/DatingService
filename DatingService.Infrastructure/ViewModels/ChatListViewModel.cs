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
        public string Filter { get; set; }
        public Chat SelectChat { get; set; }

        public List<Chat> Chats { get; set; }

        public PageViewModel PageViewModel { get; set; }
    }
}
