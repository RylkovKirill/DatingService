using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Interfaces
{
    public interface IChatService
    {
        Chat Get(Guid id);
        Chat Get(ApplicationUser user1, ApplicationUser user2);
        IQueryable<Chat> GetAll();
        IQueryable<Chat> GetAll(ApplicationUser user);
        void Add(Chat chat);
        void Update(Chat chat);
        void Remove(Guid id);
    }
}
