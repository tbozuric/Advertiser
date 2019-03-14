using DomainModel;
using FluentNHibernate.Mapping;

namespace DataAccessLayer.Mappings
{
    public class VideoWallMap : ClassMap<VideoWall>
    {
        public VideoWallMap()
        {
            Id(videoWall => videoWall.Id).GeneratedBy.Native();
            Map(wall => wall.Width);
            Map(wall => wall.Height);
            Map(wall => wall.Status);

            Component(x => x.Location, m =>
            {
                m.Map(x => x.City);
                m.Map(x => x.Street);
                m.Map(x => x.ZipCode);
            });

            HasMany(wall => wall.Schedules).Cascade.SaveUpdate().Not.LazyLoad();
            HasMany(wall => wall.Servicers).Cascade.SaveUpdate().Not.LazyLoad();
        }
    }
}