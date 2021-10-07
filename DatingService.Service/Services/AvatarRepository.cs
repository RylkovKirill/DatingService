using DatingService.Domain.Entities;
using DatingService.Persistence;
using DatingService.Service.Interfaces;
using System;
using System.Linq;

namespace DatingService.Service.Services
{
    public class AvatarRepository : IAvatarRepository
    {
        private readonly ApplicationDbContext _context;

        public AvatarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Avatar GetByUserId(Guid userId)
        {
            return _context.Avatars.FirstOrDefault(a => a.UserId == userId);
        }
    }
}
