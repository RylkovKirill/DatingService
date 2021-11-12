using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Services
{
    public class ChatService : IChatService
    {
        private readonly IRepository<Chat> _repository;

        public ChatService(IRepository<Chat> repository)
        {
            _repository = repository;
        }

        public Chat Get(Guid id)
        {
            return _repository.Get(id);
        }

        public Chat Get(ApplicationUser user1, ApplicationUser user2)
        {
            return _repository.GetAll().Where(r => r.Users.Contains(user1) && r.Users.Contains(user2)).SingleOrDefault();
        }

        public IQueryable<Chat> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<Chat> GetAll(ApplicationUser user)
        {
            return _repository.GetAll().Where(c => c.Users.Contains(user));
        }


        public void Add(Chat chat)
        {
            _repository.Add(chat);
        }

        public void Update(Chat chat)
        {
            _repository.Update(chat);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(Get(id));
        }
    }
}
