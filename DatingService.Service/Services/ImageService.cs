using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Persistence;
using DatingService.Service.Interfaces;
using System;
using System.Linq;

namespace DatingService.Service.Services
{
    public class ImageService : IImageService
    {
        private readonly IRepository<Image> _repository;

        public ImageService(IRepository<Image> repository)
        {
            _repository = repository;
        }

        public Image Get(Guid id)
        {
            return _repository.Get(id);
        }
    }
}
