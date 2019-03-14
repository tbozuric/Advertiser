using DomainModel;
using FluentNHibernate.Mapping;

namespace DataAccessLayer.Mappings
{
    public class ServiceMap : ClassMap<Service>
    {
        public ServiceMap()
        {
            Id(service => service.Id).GeneratedBy.Native();
            Map(service => service.ServiceStart);
            Map(service => service.ServiceEnd);
            Map(service => service.FailureType);
            References(service => service.VideoWall).Cascade.Merge().Not.LazyLoad();
            References(service => service.ServicedBy).Cascade.Merge().Not.LazyLoad();
        }
    }
}