using System;

namespace DomainModel
{
    public class Service
    {
        public virtual int Id { get; set; }

        private Employee _servicedBy;
        private DateTime _serviceStart;

        private DateTime _serviceEnd;

        private FailureType _failureType;
        private VideoWall _videoWall;

        public virtual VideoWall VideoWall
        {
            get => _videoWall;
            set => _videoWall = value;
        }

        public virtual Employee ServicedBy
        {
            get => _servicedBy;
            set => _servicedBy = value;
        }

        public virtual DateTime ServiceStart
        {
            get => _serviceStart;
            set => _serviceStart = value;
        }

        public virtual DateTime ServiceEnd
        {
            get => _serviceEnd;
            set => _serviceEnd = value;
        }

        public virtual FailureType FailureType
        {
            get => _failureType;
            set => _failureType = value;
        }

        protected Service()
        {

        }
        public Service(Employee servicedBy, DateTime serviceStart, DateTime serviceEnd, FailureType? failureType, VideoWall videoWall)
        {

            _servicedBy = servicedBy ?? throw new InvalidValueException("Servicer must be selected!");
            _videoWall = videoWall ?? throw new InvalidValueException("Video wall must be selected!");
            _failureType = failureType ?? throw new InvalidValueException("Failure type must be selected!");


            if (DateTime.Compare(serviceStart, serviceEnd) >= 0)
            {
                throw new DateTimeRuleException("Service start date must be before end date!");
            }

            _servicedBy = servicedBy;
            _serviceStart = serviceStart;
            _serviceEnd = serviceEnd;
            _videoWall = videoWall;

        }
    }
}