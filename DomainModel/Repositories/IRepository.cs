using System;
using System.Linq;
using System.Linq.Expressions;

namespace DomainModel.Repositories
{
    public interface IRepository<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T FindBy(int id);
        IQueryable<T> All();
        T FindBy(Expression<Func<T, bool>> expression);
    }
}