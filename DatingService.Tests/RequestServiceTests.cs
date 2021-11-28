using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Domain.Enums;
using DatingService.Persistence;
using DatingService.Service;
using DatingService.Service.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DatingService.Tests
{
    public class RequestServiceTests
    {
        private ApplicationDbContext applicationDbContext;
        private Repository<Request> repository;
        private RequestService requestService;
        [Fact]
        public void GetRequestTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            Guid id = Guid.NewGuid();
            applicationDbContext.Requests.Add(new Request() { Id = id });
            applicationDbContext.SaveChanges();
            var request = requestService.Get(id);
            Assert.NotNull(request);
            Assert.IsType<Request>(request);
            Assert.Equal(id, request.Id);
            
        }
        [Fact]
        public void GetRequestsTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Requests.Add(new Request() { Id = Guid.NewGuid() });
            }
            applicationDbContext.SaveChanges();
            var requests = requestService.GetAll();
            Assert.NotNull(requests);
            Assert.Equal(10, requests.Count());
        }
        [Fact]
        public void GetRequestsByUserTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            var user2 = UserHelper.AddUser(applicationDbContext);
            for (int i = 0; i < 5; i++)
            {
                applicationDbContext.Requests.Add(new Request() { Id = Guid.NewGuid(), ReceiverId = user2.Id, Receiver = user2, SenderId = user.Id, Sender = user, RequestStatus= RequestStatus.Considered });
                applicationDbContext.Requests.Add(new Request() { Id = Guid.NewGuid(), SenderId = user2.Id, Sender = user2, ReceiverId = user.Id,Receiver = user, RequestStatus = RequestStatus.Considered });
                
            }
            applicationDbContext.SaveChanges();
            var requests = requestService.GetAllByUser(user);
            Assert.NotNull(requests);
            Assert.Equal(10, requests.Count());
        }
        [Fact]
        public void GetOutgoingRequestsByUserTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            var user2 = UserHelper.AddUser(applicationDbContext);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Requests.Add(new Request() { Id = Guid.NewGuid(), ReceiverId = user2.Id, Receiver = user2, SenderId = user.Id, Sender = user, RequestStatus = RequestStatus.Considered });
                applicationDbContext.Requests.Add(new Request() { Id = Guid.NewGuid(), SenderId = user2.Id, Sender = user2, ReceiverId = user.Id, Receiver = user, RequestStatus = RequestStatus.Considered });

            }
            applicationDbContext.SaveChanges();
            var requests = requestService.GetAllOutgoingByUser(user);
            Assert.NotNull(requests);
            Assert.Equal(10, requests.Count());
            requests = requestService.GetAllByUser(user);
            Assert.NotNull(requests);
            Assert.Equal(20, requests.Count());
        }
        [Fact]
        public void GetIncomingRequestsByUserTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            var user2 = UserHelper.AddUser(applicationDbContext);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Requests.Add(new Request() { Id = Guid.NewGuid(), ReceiverId = user2.Id, Receiver = user2, SenderId = user.Id, Sender = user, RequestStatus = RequestStatus.Considered });
                applicationDbContext.Requests.Add(new Request() { Id = Guid.NewGuid(), SenderId = user2.Id, Sender = user2, ReceiverId = user.Id, Receiver = user, RequestStatus = RequestStatus.Considered });

            }
            applicationDbContext.SaveChanges();
            var requests = requestService.GetAllOutgoingByUser(user);
            Assert.NotNull(requests);
            Assert.Equal(10, requests.Count());
            requests = requestService.GetAllByUser(user);
            Assert.NotNull(requests);
            Assert.Equal(20, requests.Count());
        }
        [Fact]
        public void AddRequestTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            var id = Guid.NewGuid();
            requestService.Add(new Request() { Id = id });
            Assert.Equal(1, applicationDbContext.Requests.Count(p => p.Id == id));
        }
        [Fact]
        public void UpdateRequestTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            var user2 = UserHelper.AddUser(applicationDbContext);
            var id = Guid.NewGuid();
            applicationDbContext.Requests.Add(new Request() { Id = id, ReceiverId = user2.Id, Receiver = user2, SenderId = user.Id, Sender = user, RequestStatus = RequestStatus.Considered });
            applicationDbContext.SaveChanges();
            Request request = applicationDbContext.Requests.SingleOrDefault(s => s.Id == id);
            request.SenderId = user2.Id ;
            requestService.Update(request);
            Assert.Equal(1, applicationDbContext.Requests.Count(p => p.SenderId == user2.Id));
        }
        [Fact]
        public void RemoveRequestTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            
            var id = Guid.NewGuid();
            applicationDbContext.Requests.Add(new Request() { Id = id });
            applicationDbContext.SaveChanges();
            requestService.Remove(id);
            
            Assert.Equal(0, applicationDbContext.Requests.Count());
        }
        [Fact]
        public void UserFriendsTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            var user2 = UserHelper.AddUser(applicationDbContext);
            applicationDbContext.Requests.Add(new Request() { Id = Guid.NewGuid(), ReceiverId = user2.Id, Receiver = user2, SenderId = user.Id, Sender = user, RequestStatus = RequestStatus.Accepted });



            applicationDbContext.SaveChanges();
            var requests = requestService.GetUserFriends(user).ToListAsync();
            Assert.NotNull(requests);
            Assert.Contains(user2, requests.Result);
        }
        [Fact]
        public void UserRequestsTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Request>(applicationDbContext);
            requestService = new RequestService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            var user2 = UserHelper.AddUser(applicationDbContext);
            applicationDbContext.Requests.Add(new Request() { Id = Guid.NewGuid(), ReceiverId = user2.Id, Receiver = user2, SenderId = user.Id, Sender = user, RequestStatus = RequestStatus.Accepted });



            applicationDbContext.SaveChanges();
            var requests = requestService.GetUserRequests(user).ToListAsync();
            Assert.NotNull(requests);
            Assert.Contains(user2, requests.Result);
        }
        


    }
}
