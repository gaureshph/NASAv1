using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NASAv1.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
        T Find(int id);
        IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
    }
}
