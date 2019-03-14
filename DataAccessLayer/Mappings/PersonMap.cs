using DomainModel;
using FluentNHibernate.Mapping;

namespace DataAccessLayer.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.Oib).Unique();
            Map(p => p.Name);
            Map(p => p.Surname);

            DiscriminateSubClassesOnColumn("type");
        }
    }
}
