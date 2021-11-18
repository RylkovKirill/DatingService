using DatingService.Domain.Entities;
using DatingService.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Services
{
    public class ReportCategoryService : IReportCategoryService
    {
        private readonly IRepository<ReportCategory> _repository;

        public ReportCategoryService(IRepository<ReportCategory> repository)
        {
            _repository = repository;
        }

        public ReportCategory Get(Guid id)
        {
            return _repository.Get(id);
        }

        public IQueryable<ReportCategory> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(ReportCategory category)
        {
            _repository.Add(category);
        }

        public void Update(ReportCategory category)
        {
            _repository.Update(category);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(Get(id));
        }
    }
}
