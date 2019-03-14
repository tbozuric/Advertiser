using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using FluentNHibernate.Mapping;

namespace DataAccessLayer.Mappings
{
    public class EmployeeMap : SubclassMap<Employee>
    {
         
        public EmployeeMap()
        {
            DiscriminatorValue("EMP");
            HasMany(p => p.ResponsibleForServicingVideoWalls).Cascade.SaveUpdate();
        }

    }
}
