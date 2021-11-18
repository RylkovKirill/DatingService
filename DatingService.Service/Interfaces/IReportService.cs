using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Interfaces
{
    public interface IReportService
    {
        Report Get(Guid id);
        IQueryable<Report> GetAll();
        IQueryable<Report> GetAll(ApplicationUser user);
        void Add(Report report);
        void Update(Report report);
        void Remove(Guid id);
    }
}
