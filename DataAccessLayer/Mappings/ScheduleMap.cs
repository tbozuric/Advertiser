using DomainModel;
using FluentNHibernate.Mapping;

namespace DataAccessLayer.Mappings
{
    public class ScheduleMap : ClassMap<Schedule>
    {
        public ScheduleMap()
        {
            Id(schedule => schedule.Id).GeneratedBy.Native();
            Map(schedule => schedule.Name).Unique();
            Map(schedule => schedule.ScheduleStart);
            Map(schedule => schedule.ScheduleStop);
            HasMany(schedule => schedule.ScheduleEntries).Component(m =>
            {
                m.Map(entry => entry.StartTime);
                m.Map(entry => entry.EndTime);
                m.References(entry => entry.Ad).Cascade.SaveUpdate().Not.LazyLoad();
            }).Cascade.SaveUpdate().Not.LazyLoad();
        }
    }
}