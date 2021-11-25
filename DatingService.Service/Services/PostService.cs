using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _repository;

        public PostService(IRepository<Post> repository)
        {
            _repository = repository;
        }

        public Post Get(Guid id)
        {
            return _repository.Get(id);
        }

        public IQueryable<Post> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<Post> GetAll(ApplicationUser user)
        {
            return _repository.GetAll().Where(p => p.User.Equals(user)).Include(p => p.Image);
        }

        public IQueryable<Post> GetAll(string searchQuery)
        {
            return _repository.GetAll().Where(a => a.Title.Contains(searchQuery));
        }

        public void Add(Post post)
        {
            _repository.Add(post);
        }

        public void Update(Post post)
        {
            _repository.Update(post);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(Get(id));
        }
    }
}
