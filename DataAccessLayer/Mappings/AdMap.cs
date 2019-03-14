using DomainModel;
using FluentNHibernate.Mapping;

namespace DataAccessLayer.Mappings
{
    public class AdMap : ClassMap<Ad>
    {
        public AdMap()
        {
            Id(ad => ad.Id).GeneratedBy.Native();
            Map(ad => ad.Name).Unique();
            Map(ad => ad.AdContent);
        }
    }
}