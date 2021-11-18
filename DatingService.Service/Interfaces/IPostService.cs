using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Interfaces
{
    public interface IPostService
    {
        Post Get(Guid id);
        IQueryable<Post> GetAll();
        IQueryable<Post> GetAll(ApplicationUser user);
        IQueryable<Post> GetAll(string searchQuery);
        void Add(Post post);
        void Update(Post post);
        void Remove(Guid id);
    }
}
