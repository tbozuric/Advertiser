using System.Linq;
using DomainModel;
using NHibernate;

namespace DataAccessLayer.Repositories
{
    public class ServiceRepository : AbstractRepository<Service>
    {
        private static ServiceRepository _instance;

        private ServiceRepository()
        {
        }

        public static ServiceRepository GetInstance()
        {
            return _instance ?? (_instance = new ServiceRepository());
        }

        public override bool Add(Service entity)
        {
          
            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(entity);
                    transaction.Commit();
                }
            }

            NotifyObservers();
            return true;
        }


        public override Service FindBy(int id)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                return session
                    .Query<Service>().SingleOrDefault(x => x.Id == id);
            }
        }
    }
}