using System;

namespace DomainModel
{
    public class RentWall
    {
        public virtual int Id { get; set; }
        private Person _renter;
        private VideoWall _videoWall;
        private DateTime _start;
        private DateTime _end;
        private float _price;

        public virtual VideoWall VideoWall

        {
            get => _videoWall;
            set => _videoWall = value;
        }

        public virtual DateTime StartRentTime
        {
            get => _start;
            set => _start = value;
        }

        public virtual DateTime EndRentTime
        {
            get => _end;
            set => _end = value;
        }

        public virtual float Price
        {
            get => _price;
            set => _price = value;
        }

        public virtual Person Renter
        {
            get => _renter;
            set => _renter = value;
        }

        public RentWall()
        {
        }

        public RentWall(VideoWall videoWall,Person renter,  DateTime start, DateTime end, float price)
        {
            if (DateTime.Compare(start, end) >= 0)
            {
                throw new DateTimeRuleException("Begin date must be before end date!");
            }

            if (price <= 0)
            {
                throw new InvalidPriceException("Price must be greater than 0!");
            }

            _videoWall = videoWall ?? throw new VideoWallNullReferenceException("Video wall must not be null!");
            _start = start;
            _end = end;
            _price = price;
            _renter = renter;
        }
    }
}