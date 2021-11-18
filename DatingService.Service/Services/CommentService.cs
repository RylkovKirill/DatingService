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
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _repository;

        public CommentService(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public Comment Get(Guid id)
        {
            return _repository.Get(id);
        }

        public IQueryable<Comment> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<Comment> GetAll(ApplicationUser user)
        {
            return _repository.GetAll().Where(c => c.User.Equals(user));
        }

        public IQueryable<Comment> GetAll(Post post)
        {
            return _repository.GetAll().Where(c => c.Post.Equals(post)).OrderByDescending(c => c.DateUpdated);
        }

        public void Add(Comment comment)
        {
            _repository.Add(comment);
        }

        public void Update(Comment comment)
        {
            _repository.Update(comment);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(Get(id));
        }
    }
}
