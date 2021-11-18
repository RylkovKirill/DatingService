using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Interfaces
{
    public interface IReportCategoryService
    {
        ReportCategory Get(Guid id);
        IQueryable<ReportCategory> GetAll();
        void Add(ReportCategory category);
        void Update(ReportCategory category);
        void Remove(Guid id);
    }
}
