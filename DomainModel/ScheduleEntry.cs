using System;
using System.IO;

namespace DomainModel
{
    public class ScheduleEntry
    {
        private Ad _ad;
        private DateTime _start;
        private DateTime _end;

        public virtual Ad Ad
        {
            get => _ad;
            set => _ad = value;
        }

        public virtual DateTime StartTime
        {
            get => _start;
            set => _start = value;
        }

        public virtual DateTime EndTime
        {
            get => _end;
            set => _end = value;
        }

        protected ScheduleEntry()
        {

        }
        public ScheduleEntry(Ad ad, DateTime start, DateTime end)
        {
            _ad = ad ?? throw new AdNullReferenceException("Ad must be selected!");
            if (DateTime.Compare(start, end) >= 0)
            {
                throw new DateTimeRuleException("Begin date must be before end date!");
            }

            _start = start;
            _end = end;
        }
    }
}