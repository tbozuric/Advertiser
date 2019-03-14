using DomainModel;
using FluentNHibernate.Mapping;

namespace DataAccessLayer.Mappings
{
    public class AddressMap : ComponentMap<Address>
    {
        public AddressMap()
        {
            Map(p => p.City);
            Map(p => p.Street);
            Map(p => p.ZipCode);
        }
    }
}