using DatingService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Service.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity<Guid>
    {
        IEnumerable<TEntity> All();

        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
