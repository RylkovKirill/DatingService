using DatingService.Domain.Entities;
using DatingService.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Services
{
    public class GenderService : IGenderService
    {
        private readonly IRepository<Gender> _repository;

        public GenderService(IRepository<Gender> repository)
        {
            _repository = repository;
        }

        public Gender Get(Guid id)
        {
            return _repository.Get(id);
        }

        public IQueryable<Gender> All()
        {
            return _repository.GetAll();
        }

        public void Add(Gender gender)
        {
            _repository.Add(gender);
        }

        public void Update(Gender gender)
        {
            _repository.Update(gender);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(Get(id));
        }
    }
}
