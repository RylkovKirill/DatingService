using DatingService.Domain.Entities;
using DatingService.Persistence;
using DatingService.Service;
using DatingService.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using Xunit;

namespace DatingService.Tests
{
    public class MessageServiceTests
    {

        private ApplicationDbContext applicationDbContext;
        private Repository<Message> repository;
        private MessageService messageService;


        [Fact]
        public void GetMessageTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Message>(applicationDbContext);
            messageService = new MessageService(repository);
            Guid id = Guid.NewGuid();
            applicationDbContext.Messages.Add(new Message() { Id = id, Content = "Content" });
            applicationDbContext.SaveChanges();
            var message = messageService.Get(id);
            Assert.NotNull(message);
            Assert.IsType<Message>(message);
            Assert.Equal(id, message.Id);
            Assert.Equal("Content", message.Content);
        }
        [Fact]
        public void GetCommemtsTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Message>(applicationDbContext);
            messageService = new MessageService(repository);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Messages.Add(new Message() { Id = Guid.NewGuid(), Content = "Content" });
            }
            applicationDbContext.SaveChanges();
            var messages = messageService.GetAll();
            Assert.NotNull(messages);
            Assert.Equal(10, messages.Count());
        }
        [Fact]
        public void GetCommentsByUserTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Message>(applicationDbContext);
            messageService = new MessageService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Messages.Add(new Message() { Id = Guid.NewGuid(), Content = "Content", User = user });
            }
            applicationDbContext.SaveChanges();
            var messages = messageService.GetAll(user);
            Assert.NotNull(messages);
            Assert.Equal(10, messages.Count());
            for (int i = 0; i < messages.Count(); i++)
            {
                Assert.Equal(user, messages.ToArray()[i].User);
            }
        }
        [Fact]
        public void GetCommentsByPostChats()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Message>(applicationDbContext);
            messageService = new MessageService(repository);
            Guid id = Guid.NewGuid();
            Chat chat = new Chat() { Id = id };
            applicationDbContext.Chats.Add(chat);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Messages.Add(new Message() { Id = Guid.NewGuid(), Content = "Content", Chat = chat });
            }
            applicationDbContext.SaveChanges();
            var messages = messageService.GetAll(chat);
            Assert.NotNull(messages);
            Assert.Equal(10, messages.Count());
            for (int i = 0; i < messages.Count(); i++)
            {
                Assert.Equal(chat, messages.ToArray()[i].Chat);
            }
        }
        [Fact]
        public void AddCommentTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Message>(applicationDbContext);
            messageService = new MessageService(repository);
            messageService.Add(new Message() { Id = Guid.NewGuid(), Content = "Content" });
            Assert.Equal(1, applicationDbContext.Messages.Count(p => p.Content == "Content"));
        }
        [Fact]
        public void UpdateCommentTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Message>(applicationDbContext);
            messageService = new MessageService(repository);
            Guid id = Guid.NewGuid();
            messageService.Add(new Message() { Id = id, Content = "Content" });
            applicationDbContext.SaveChanges();
            Message message = applicationDbContext.Messages.SingleOrDefault(s => s.Id == id);
            message.Content = "Update content";
            messageService.Update(message);
            Assert.Equal(1, applicationDbContext.Messages.Count(p => p.Content == "Update content"));
        }
        [Fact]
        public void RemoveCommentTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Message>(applicationDbContext);
            messageService = new MessageService(repository);
            Guid id = Guid.NewGuid();
            applicationDbContext.Messages.Add(new Message() { Id = id, Content = "Content" });
            applicationDbContext.SaveChanges();
            messageService.Remove(id);
            Assert.Equal(0, applicationDbContext.Messages.Count(p => p.Content == "Content"));
        }

    }
}
