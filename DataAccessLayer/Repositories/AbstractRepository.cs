using System;
using System.Linq;
using System.Linq.Expressions;
using BaseLib;
using DomainModel.Repositories;
using NHibernate;

namespace DataAccessLayer.Repositories
{
    public abstract class AbstractRepository<T> : Subject, IRepository<T> where T : class
    {
        public abstract T FindBy(int id);
        public abstract bool Add(T entity);

        public bool Update(T entity)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(entity);
                    transaction.Commit();
                }
            }

            NotifyObservers();
            return true;
        }

        public bool Delete(T entity)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(entity);
                    transaction.Commit();
                }
            }

            NotifyObservers();
            return true;
        }


        public IQueryable<T> All()
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                return session.Query<T>().ToList().AsQueryable();
            }
        }

        public T FindBy(Expression<Func<T, bool>> expression)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                return session.Query<T>()
                    .Where(expression).FirstOrDefault();
            }
        }
    }
}