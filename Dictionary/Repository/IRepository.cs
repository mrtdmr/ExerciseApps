using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dictionary.Repository
{
    public interface IRepository<T> where T:class
    {
        Task Add(T entity);
        Task Update(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        Task Save();
    }
}
