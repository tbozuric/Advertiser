using System.Linq;
using BaseLib;
using DomainModel;
using NHibernate;

namespace DataAccessLayer.Repositories
{
    public class VideoWallRepository : AbstractRepository<VideoWall>
    {
        private static VideoWallRepository _instance;

        private VideoWallRepository()
        {
        }

        public static VideoWallRepository GetInstance()
        {
            return _instance ?? (_instance = new VideoWallRepository());
        }

        public override bool Add(VideoWall entity)
        {
            var list = All();

            foreach (var currentVideoWall in list)
            {
                if (currentVideoWall.Location.Equals(entity.Location))
                {
                    throw new VideoWallAtLocationAlreadyExistsException("Video wall already exists in database!");
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


        public override VideoWall FindBy(int id)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                return session
                    .Query<VideoWall>().SingleOrDefault(x => x.Id == id);
            }
        }
    }
}