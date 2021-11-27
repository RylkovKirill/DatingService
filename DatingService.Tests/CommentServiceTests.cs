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
    public class CommentServiceTests
    {
        
        private ApplicationDbContext applicationDbContext;
        private Repository<Comment> repository;
        private CommentService commentService;
        

        [Fact]
        public void GetCommentTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Comment>(applicationDbContext);
            commentService = new CommentService(repository);
            Guid id = Guid.NewGuid();
            applicationDbContext.Comments.Add(new Comment() { Id = id, Content = "Content" });
            applicationDbContext.SaveChanges();
            var comment = commentService.Get(id);
            Assert.NotNull(comment);
            Assert.IsType<Comment>(comment);
            Assert.Equal(id, comment.Id);
            Assert.Equal("Content", comment.Content);
        }
        [Fact]
        public void GetCommemtsTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Comment>(applicationDbContext);
            commentService = new CommentService(repository);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Comments.Add(new Comment() { Id = Guid.NewGuid(), Content = "Content" });
            }
            applicationDbContext.SaveChanges();
            var comments = commentService.GetAll();
            Assert.NotNull(comments);
            Assert.Equal(10, comments.Count());
        }
        [Fact]
        public void GetCommentsByUserTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Comment>(applicationDbContext);
            commentService = new CommentService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Comments.Add(new Comment() { Id = Guid.NewGuid(), Content = "Content", User = user });
            }
            applicationDbContext.SaveChanges();
            var comments = commentService.GetAll(user);
            Assert.NotNull(comments);
            Assert.Equal(10, comments.Count());
            for (int i = 0; i < comments.Count(); i++)
            {
                Assert.Equal(user, comments.ToArray()[i].User);
            }
        }
        [Fact]
        public void GetCommentsByPostTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Comment>(applicationDbContext);
            commentService = new CommentService(repository);
            Guid id = Guid.NewGuid();
            Post post = new Post() { Id = id, Title = "Title", Content = "Content" };
            applicationDbContext.Posts.Add(post);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Comments.Add(new Comment() { Id = Guid.NewGuid(), Content = "Content", Post = post });
            }
            applicationDbContext.SaveChanges();
            var comments = commentService.GetAll(post);
            Assert.NotNull(comments);
            Assert.Equal(10, comments.Count());
            for (int i = 0; i < comments.Count(); i++)
            {
                Assert.Equal(post, comments.ToArray()[i].Post);
            }
        }
        [Fact]
        public void AddCommentTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Comment>(applicationDbContext);
            commentService = new CommentService(repository);
            commentService.Add(new Comment() { Id = Guid.NewGuid(), Content = "Content" });
            Assert.Equal(1, applicationDbContext.Comments.Count(p => p.Content == "Content"));
        }
        [Fact]
        public void UpdateCommentTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Comment>(applicationDbContext);
            commentService = new CommentService(repository);
            Guid id = Guid.NewGuid();
            applicationDbContext.Comments.Add(new Comment() { Id = id, Content = "Content" });
            applicationDbContext.SaveChanges();
            Comment comment = applicationDbContext.Comments.SingleOrDefault(s => s.Id == id);
            comment.Content = "Update content";
            commentService.Update(comment);
            Assert.Equal(1, applicationDbContext.Comments.Count(p => p.Content == "Update content"));
        }
        [Fact]
        public void RemoveCommentTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Comment>(applicationDbContext);
            commentService = new CommentService(repository);
            Guid id = Guid.NewGuid();
            applicationDbContext.Comments.Add(new Comment() { Id = id, Content = "Content" });
            applicationDbContext.SaveChanges();
            commentService.Remove(id);
            Assert.Equal(0, applicationDbContext.Comments.Count(p => p.Content == "Content"));
        }

    }
}
