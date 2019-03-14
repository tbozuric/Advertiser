using System.Linq;
using BaseLib;
using DomainModel;
using NHibernate;

namespace DataAccessLayer.Repositories
{
    public class ScheduleRepository : AbstractRepository<Schedule>
    {
        private static ScheduleRepository _instance;

        private ScheduleRepository()
        {
        }

        public static ScheduleRepository GetInstance()
        {
            return _instance ?? (_instance = new ScheduleRepository());
        }


        public override bool Add(Schedule entity)
        {

            var list = All();


            foreach (var currentSchedule in list)
            {
                if (currentSchedule.Name.Equals(entity.Name))
                {
                    throw new ScheduleWithNameAlreadyExistsException();
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


        public override Schedule FindBy(int id)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                return session
                    .Query<Schedule>().SingleOrDefault(x => x.Id == id);
            }
        }
    }
}