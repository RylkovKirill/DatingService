using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Domain.Enums;
using DatingService.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRepository<Request> _repository;

        public RequestService(IRepository<Request> repository)
        {
            _repository = repository;
        }

        public Request Get(Guid id)
        {
            return _repository.Get(id);
        }

        public Request Get(ApplicationUser user1, ApplicationUser user2)
        {
            return _repository.GetAll().Where((r => (r.Sender == user1 && r.Receiver == user2) || (r.Sender == user2 && r.Receiver == user1))).SingleOrDefault();
        }

        public IQueryable<Request> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<Request> GetAllByUser(ApplicationUser user)
        {
            return _repository.GetAll().Where(r => (r.Sender.Equals(user) && r.RequestStatus == RequestStatus.Considered) || (r.Receiver.Equals(user) && r.RequestStatus == RequestStatus.Considered));
        }

        public IQueryable<Request> GetAllOutgoingByUser(ApplicationUser user)
        {
            return _repository.GetAll().Where(r => r.Sender.Equals(user) && r.RequestStatus == RequestStatus.Considered);

        }

        public IQueryable<Request> GetAllIncomingByUser(ApplicationUser user)
        {
            return _repository.GetAll().Where(r => r.Receiver.Equals(user) && r.RequestStatus == RequestStatus.Considered);

        }

        public void Add(Request request)
        {
            _repository.Add(request);
        }

        public void Update(Request request)
        {
            _repository.Update(request);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(Get(id));
        }

        public IQueryable<ApplicationUser> GetUserFriends(ApplicationUser user)
        {
            return _repository.GetAll().Where(r => r.Sender.Equals(user) && r.RequestStatus == RequestStatus.Accepted)
                .Select(r => r.Receiver)
                .Union(_repository.GetAll().Where(r => r.Receiver.Equals(user) && r.RequestStatus == RequestStatus.Accepted)
                .Select(r => r.Sender));
        }

        public bool UserInFriendsList(IQueryable<ApplicationUser> friends, ApplicationUser user)
        {
            return friends.Contains(user);
        }

        public bool IsRequestExistence(ApplicationUser user1, ApplicationUser user2)
        {
            if (_repository.GetAll().Where((r => ((r.Sender == user1 && r.Receiver == user2) && r.RequestStatus == RequestStatus.Considered) || ((r.Sender == user2 && r.Receiver == user1) && r.RequestStatus == RequestStatus.Considered))).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
