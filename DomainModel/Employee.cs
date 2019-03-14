using System.Collections.Generic;

namespace DomainModel
{
    public class Employee : Person
    {
        public virtual IList<VideoWall> ResponsibleForServicingVideoWalls { get; set; } = new List<VideoWall>();


        public Employee(string oib, string name, string surname) : base(oib, name, surname)
        {
           
        }


        protected Employee()
        {

        }
    }
}