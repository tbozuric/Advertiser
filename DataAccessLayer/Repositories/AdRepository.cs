using System.Linq;
using BaseLib;
using DomainModel;
using NHibernate;

namespace DataAccessLayer.Repositories
{
    public class AdRepository : AbstractRepository<Ad>
    {
        private static AdRepository _instance;

        private AdRepository()
        {
        }

        public static AdRepository GetInstance()
        {
            return _instance ?? (_instance = new AdRepository());
        }


        public override bool Add(Ad entity)
        {
           
            var list = All();

            foreach (var currentAd in list)
            {
                if (currentAd.Name.Equals(entity.Name))
                {
                    throw new AdWithNameAlreadyExistsException();
                }
            }

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


        public override Ad FindBy(int id)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                return session
                    .Query<Ad>().SingleOrDefault(x => x.Id == id);
            }
        }
    }
}