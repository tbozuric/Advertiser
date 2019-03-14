using System.Linq;
using DomainModel;
using NHibernate;

namespace DataAccessLayer.Repositories
{
    public class RentalRepository : AbstractRepository<RentWall>
    {
        private static RentalRepository _instance;

        private RentalRepository()
        {
        }

        public static RentalRepository GetInstance()
        {
            return _instance ?? (_instance = new RentalRepository());
        }

        public override bool Add(RentWall entity)
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


        public override RentWall FindBy(int id)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                return session
                    .Query<RentWall>().SingleOrDefault(x => x.Id == id);
            }
        }
    }
}