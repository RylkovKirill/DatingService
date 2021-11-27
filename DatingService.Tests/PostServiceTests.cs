using DatingService.Domain.Entities;
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
    public class PostServiceTests
    {
        
        private ApplicationDbContext applicationDbContext;
        private Repository<Post> repository;
        private PostService postService;

       

        [Fact]
        public void GetPostTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Post>(applicationDbContext);
            postService = new PostService(repository);
            applicationDbContext.Posts.Add(new Post() { Id = Guid.Parse("b3d92b9c-89a6-4f28-90de-87a4c9abda53"), Title = "Title", Content = "Content" });
            applicationDbContext.SaveChanges();
            var post = postService.Get(Guid.Parse("b3d92b9c-89a6-4f28-90de-87a4c9abda53"));
            Assert.NotNull(post);
            Assert.IsType<Post>(post);
            Assert.Equal(Guid.Parse("b3d92b9c-89a6-4f28-90de-87a4c9abda53"), post.Id);
            Assert.Equal("Title", post.Title);
            Assert.Equal("Content", post.Content);
        }

        [Fact]
        public void GetPostsTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Post>(applicationDbContext);
            postService = new PostService(repository);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Posts.Add(new Post() { Id = Guid.NewGuid(), Title = "Title", Content = "Content" });
            }
            applicationDbContext.SaveChanges();
            var posts = postService.GetAll();
            Assert.NotNull(posts);
            Assert.Equal(10, posts.Count());
        }

        [Fact]
        public void GetPostsByUserTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Post>(applicationDbContext);
            postService = new PostService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Posts.Add(new Post() { Id = Guid.NewGuid(), Title = "Title", Content = "Content", User = user });
            }
            applicationDbContext.SaveChanges();
            var posts = postService.GetAll(user);
            Assert.NotNull(posts);
            Assert.Equal(10, posts.Count());
            for (int i = 0; i < posts.Count(); i++)
            {
                Assert.Equal(user, posts.ToArray()[i].User);
            }
        }
        [Fact]
        public void GetPostsBySearchTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Post>(applicationDbContext);
            postService = new PostService(repository);
            var user = UserHelper.AddUser(applicationDbContext);
            for (int i = 0; i < 10; i++)
            {
                applicationDbContext.Posts.Add(new Post() { Id = Guid.NewGuid(), Title = $"Content{i + 1}", Content = $"Content{i+1}", User = user });
            }
            applicationDbContext.SaveChanges();
            var posts = postService.GetAll("Content1");
            Assert.NotNull(posts);
            Assert.Equal(2, posts.Count());
            
        }

        

        [Fact]
        public void AddPostTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Post>(applicationDbContext);
            postService = new PostService(repository);
            postService.Add(new Post() { Id = Guid.Parse("efd081d5-dcc5-4e70-9ac0-d26a5b9aa293"), Title = "Title", Content = "Content" });
            Assert.Equal(1, applicationDbContext.Posts.Count(p => p.Title == "Title"));
        }
        
        [Fact]
        public void UpdatePostTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Post>(applicationDbContext);
            postService = new PostService(repository);
            applicationDbContext.Posts.Add(new Post() { Id = Guid.Parse("aed4a0f0-ef37-4d7d-a463-757acb5e7147"), Title = "Title", Content = "Content" });
            applicationDbContext.SaveChanges();
            Post post = applicationDbContext.Posts.SingleOrDefault(s => s.Id == Guid.Parse("aed4a0f0-ef37-4d7d-a463-757acb5e7147"));
            post.Title = "Update title";
            post.Content = "Update content";
            postService.Update(post);
            Assert.Equal(1, applicationDbContext.Posts.Count(p => p.Title == "Update title"));
            Assert.Equal("Update title", post.Title);
            Assert.Equal("Update content", post.Content);
        }
        
        [Fact]
        public void RemovePostTests()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            applicationDbContext = new ApplicationDbContext(builder.Options);
            repository = new Repository<Post>(applicationDbContext);
            postService = new PostService(repository);
            applicationDbContext.Posts.Add(new Post() { Id = Guid.Parse("d5da59f4-6cbf-4e36-ad86-70b8e66a872a"), Title = "Title", Content = "Content" });
            applicationDbContext.SaveChanges();
            postService.Remove(Guid.Parse("d5da59f4-6cbf-4e36-ad86-70b8e66a872a"));
            Assert.Equal(0, applicationDbContext.Posts.Count(p => p.Title == "Title"));
        }

       
    }
}
