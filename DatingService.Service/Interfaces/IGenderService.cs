using DatingService.Domain.Entities;
using System;
using System.Linq;

namespace DatingService.Service.Interfaces
{
    public interface IGenderService
    {
        Gender Get(Guid id);
        IQueryable<Gender> All();
        void Add(Gender gender);
        void Update(Gender gender);
        void Remove(Guid id);
    }
}
