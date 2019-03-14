using System.Collections.Generic;

namespace DomainModel
{
    public class VideoWall
    {
        public virtual int Id { get; set; }

        private short _width;
        private short _height;

        private Address _location;

        private IList<Employee> _servicers = new List<Employee>();

        private VideoWallStatus _status;

        private IList<Schedule> _schedules = new List<Schedule>();


        public virtual short Width
        {
            get => _width;
            set => _width = value;
        }

        public virtual short Height
        {
            get => _height;
            set => _height = value;
        }

        public virtual Address Location
        {
            get => _location;
            set => _location = value;
        }

        public virtual IList<Employee> Servicers
        {
            get => _servicers;
            set => _servicers = value;
        }

        public virtual VideoWallStatus Status
        {
            get => _status;
            set => _status = value;
        }

        public virtual IList<Schedule> Schedules
        {
            get => _schedules;
            set => _schedules = value;
        }

        protected VideoWall()
        {

        }

        public VideoWall(short width, short height, Address location)
        {
            _location = location ?? throw new AddressNullReferenceException("Address data must not be empty!");
            if (width < 1 || height < 1)
            {
                throw new InvalidValueException("Width and height must be greater than or equal to 1!");
            }

            _width = width;
            _height = height;
        }
    }
}