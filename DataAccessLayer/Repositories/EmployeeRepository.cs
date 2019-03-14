using System.Linq;
using BaseLib;
using DomainModel;
using NHibernate;

namespace DataAccessLayer.Repositories
{
    public class EmployeeRepository : AbstractRepository<Employee>
    {
        private static EmployeeRepository _instance;

        private EmployeeRepository()
        {
        }

        public static EmployeeRepository GetInstance()
        {
            return _instance ?? (_instance = new EmployeeRepository());
        }


        public override bool Add(Employee entity)
        {
            var list = All();

            foreach (var currentEmployee in list)
            {
                if (currentEmployee.Oib.Equals(entity.Oib))
                {
                    throw new EmployeeWithOibAlreadyExistsException("Employee with this OIB already exists!");
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


        public override Employee FindBy(int id)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                return session
                    .Query<Employee>().SingleOrDefault(x => x.Id == id);
            }
        }
    }
}