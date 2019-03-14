using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using DataAccessLayer.Mappings;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace DataAccessLayer
{
    public class NHibernateService
    {
        private static ISessionFactory _sessionFactory;


        public static ISession OpenSession()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = OpenSessionFactory();
                }

                ISession session = _sessionFactory.OpenSession();
                return session;
            }
            catch (Exception e)
            {
                throw e.InnerException ?? e;
            }
        }

        private static ISessionFactory OpenSessionFactory(bool needToCreateDatabase = false)
        {
            var nhConfig = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard
                    .ConnectionString("Data Source=Reklamator.db;Version=3")
                    .AdoNetBatchSize(100))
                .Mappings(mappings => mappings.FluentMappings.AddFromAssemblyOf<ScheduleMap>())
                .BuildConfiguration();

            if (needToCreateDatabase)
            {
                var schemaExport = new SchemaExport(nhConfig);
                schemaExport.Create(Console.WriteLine, true);
            }

            var sessionFactory = nhConfig.BuildSessionFactory();
            return sessionFactory;
        }

        public static void CreateDatabase()
        {
            _sessionFactory = OpenSessionFactory(true);
        }
    }
}