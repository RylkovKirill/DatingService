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
    public class ReportService : IReportService
    {
        private readonly IRepository<Report> _repository;

        public ReportService(IRepository<Report> repository)
        {
            _repository = repository;
        }

        public Report Get(Guid id)
        {
            return _repository.Get(id);
        }

        public IQueryable<Report> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<Report> GetAll(ApplicationUser user)
        {
            return _repository.GetAll().Where(r => r.ReceiverId == user.Id);
        }

        public void Add(Report report)
        {
            _repository.Add(report);
        }

        public void Update(Report report)
        {
            _repository.Update(report);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(Get(id));
        }
    }
}
