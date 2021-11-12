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
    public class MessageService : IMessageService
    {
        private readonly IRepository<Message> _repository;

        public MessageService(IRepository<Message> repository)
        {
            _repository = repository;
        }

        public Message Get(Guid id)
        {
            return _repository.Get(id);
        }

        public IQueryable<Message> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<Message> GetAll(ApplicationUser user)
        {
            return _repository.GetAll().Where(c => c.User.Equals(user));
        }

        public IQueryable<Message> GetAll(Chat chat)
        {
            return _repository.GetAll().Where(c => c.Chat.Equals(chat));
        }

        public void Add(Message message)
        {
            _repository.Add(message);
        }

        public void Update(Message message)
        {
            _repository.Update(message);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(Get(id));
        }
    }
}
