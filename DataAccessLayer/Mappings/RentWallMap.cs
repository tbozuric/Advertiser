using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using FluentNHibernate.Mapping;

namespace DataAccessLayer.Mappings
{
    public class RentWallMap : ClassMap<RentWall>
    {
        public RentWallMap()
        {
            Id(wall => wall.Id).GeneratedBy.Native();
            Map(rent => rent.StartRentTime);
            Map(rent => rent.EndRentTime);
            Map(rent => rent.Price);
            References(rent => rent.Renter).Cascade.SaveUpdate();
            References(rent => rent.VideoWall).Cascade.SaveUpdate().Not.LazyLoad();
        }
    }
}
