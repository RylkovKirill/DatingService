using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Persistence;
using DatingService.Service;
using DatingService.Service.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DatingService.Tests
{
    public class ChatServiceTests
    {
        private ApplicationDbContext applicationDbContext;
        private Repository<Chat> repository;
        private ChatService chatService;


        [Fact]
        public void GetChatTest()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Chat>(applicationDbContext);
            chatService = new ChatService(repository);
            Guid id = Guid.NewGuid();
            applicationDbContext.Chats.Add(new Chat() { Id = id});
            applicationDbContext.SaveChanges();
            var chat = chatService.Get(id);
            Assert.NotNull(chat);
            Assert.IsType<Chat>(chat);
            Assert.Equal(id, chat.Id);
            
        }
        [Fact]
        public void GetChatUsersTest()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Chat>(applicationDbContext);
            chatService = new ChatService(repository);
            Guid id = Guid.NewGuid();
            
            var user1 = UserHelper.AddUser(applicationDbContext);
            var user2 = UserHelper.AddUser(applicationDbContext);
            
            List<ApplicationUser> UserList = new List<ApplicationUser>() { user1, user2 };
            ICollection<ApplicationUser> userCollection = UserList;
            applicationDbContext.Chats.Add(new Chat() { Id = id, Users = userCollection });
            applicationDbContext.SaveChanges();
            var chat = chatService.Get(user1, user2);
            Assert.NotNull(chat);
            Assert.IsType<Chat>(chat);
            Assert.Equal(id, chat.Id);
            Assert.True(chat.Users.Contains(user1));
            Assert.True(chat.Users.Contains(user2));
           
            

        }

        [Fact]
        public void GetChatUsersDescendingTest()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Chat>(applicationDbContext);
            chatService = new ChatService(repository);
            Guid id = Guid.NewGuid();

            var user1 = UserHelper.AddUser(applicationDbContext);
            var user2 = UserHelper.AddUser(applicationDbContext);

            List<ApplicationUser> UserList = new List<ApplicationUser>() { user2, user1 };
            ICollection<ApplicationUser> userCollection = UserList;
            applicationDbContext.Chats.Add(new Chat() { Id = id, Users = userCollection });
            applicationDbContext.SaveChanges();
            var chat = chatService.Get(user1, user2);
            Assert.NotNull(chat);
            Assert.IsType<Chat>(chat);
            Assert.Equal(id, chat.Id);
            Assert.True(chat.Users.Contains(user1));
            Assert.True(chat.Users.Contains(user2));



        }

        [Fact]
        public void GetChatsTest()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Chat>(applicationDbContext);
            chatService = new ChatService(repository);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Chats.Add(new Chat() { Id = Guid.NewGuid()});
            }
            applicationDbContext.SaveChanges();
            var chats = chatService.GetAll();
            Assert.NotNull(chats);
            Assert.Equal(10, chats.Count());
        }
        [Fact]
        public void GetChatsByUserTest()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Chat>(applicationDbContext);
            chatService = new ChatService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            List<ApplicationUser> UserList = new List<ApplicationUser>() { user };
            ICollection<ApplicationUser> userCollection = UserList;
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Chats.Add(new Chat() { Id = Guid.NewGuid(), Users = userCollection });
            }
            applicationDbContext.SaveChanges();
            var chats = chatService.GetAll(user);
            Assert.NotNull(chats);
            Assert.Equal(10, chats.Count());
            for (int i = 0; i < chats.Count(); i++)
            {
                Assert.True(chats.ToArray()[i].Users.Contains(user));
            }
        }
        [Fact]
        public void AddChatTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Chat>(applicationDbContext);
            chatService = new ChatService(repository);
            chatService.Add(new Chat() { Id = Guid.NewGuid() });
            Assert.Equal(1, applicationDbContext.Chats.Count());
        }
        [Fact]
        public void UpdateChatTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Chat>(applicationDbContext);
            chatService = new ChatService(repository);
            Guid id = Guid.NewGuid();
            var user1 = UserHelper.AddUser(applicationDbContext);
            var user2 = UserHelper.AddUser(applicationDbContext);
            List<ApplicationUser> UserList = new List<ApplicationUser>() { user1 };
            ICollection<ApplicationUser> userCollection = UserList;
            
            applicationDbContext.Chats.Add(new Chat() { Id = id, Users = userCollection });
            applicationDbContext.SaveChanges();
            Chat chat = applicationDbContext.Chats.SingleOrDefault(s => s.Id == id);
            UserList = new List<ApplicationUser>() { user2, user1 };
            userCollection = UserList;
            chat.Users = userCollection;
            chatService.Update(chat);
            Assert.Equal(1, applicationDbContext.Chats.Count(p => p.Users.Count == 2));
        }
        [Fact]
        public void RemoveChatTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Chat>(applicationDbContext);
            chatService = new ChatService(repository);
            Guid id = Guid.NewGuid();
            var user1 = UserHelper.AddUser(applicationDbContext);
            
            List<ApplicationUser> UserList = new List<ApplicationUser>() { user1 };
            ICollection<ApplicationUser> userCollection = UserList;

            applicationDbContext.Chats.Add(new Chat() { Id = id, Users = userCollection });
            applicationDbContext.SaveChanges();
            chatService.Remove(id);
            
            Assert.Equal(0, applicationDbContext.Chats.Count(p => p.Users.Count == 1));
        }
    }
}
