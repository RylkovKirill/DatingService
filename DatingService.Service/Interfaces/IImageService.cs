using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using System;

namespace DatingService.Service.Interfaces
{
    public interface IImageService
    {
        public Image Get(Guid id);
    }
}
