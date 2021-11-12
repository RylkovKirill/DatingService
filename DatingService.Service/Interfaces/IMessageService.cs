using DatingService.Domain.Entities;
using DatingService.Domain.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Interfaces
{
    public interface IMessageService
    {
        Message Get(Guid id);
        IQueryable<Message> GetAll();
        IQueryable<Message> GetAll(ApplicationUser user);
        IQueryable<Message> GetAll(Chat chat);
        void Add(Message message);
        void Update(Message message);
        void Remove(Guid id);
    }
}
