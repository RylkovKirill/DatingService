using DatingService.Domain.Entities;
using System;

namespace DatingService.Service.Interfaces
{
    public interface IAvatarRepository
    {
        public Avatar GetByUserId(Guid userId);
    }
}
