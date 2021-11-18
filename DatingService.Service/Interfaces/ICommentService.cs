using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using System;
using System.Linq;

namespace DatingService.Service.Interfaces
{
    public interface ICommentService
    {
        Comment Get(Guid id);
        IQueryable<Comment> GetAll();
        IQueryable<Comment> GetAll(ApplicationUser user);
        IQueryable<Comment> GetAll(Post post);
        void Add(Comment user);
        void Update(Comment user);
        void Remove(Guid id);
    }
}
