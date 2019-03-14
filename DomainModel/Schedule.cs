using System;
using System.Collections.Generic;
using System.IO;
using static System.String;

namespace DomainModel
{
    public class Schedule
    {
        private string _name;

        private DateTime _scheduleStart;

        private DateTime _scheduleStop;

        private IList<ScheduleEntry> _entries = new List<ScheduleEntry>();

        public virtual int Id { get; set; }

        public virtual string Name
        {
            get => _name;
            set => _name = value;
        }

        public virtual DateTime ScheduleStart
        {
            get => _scheduleStart;
            set => _scheduleStart = value;
        }

        public virtual DateTime ScheduleStop
        {
            get => _scheduleStop;
            set => _scheduleStop = value;
        }

        public virtual IList<ScheduleEntry> ScheduleEntries
        {
            get => _entries;
            set => _entries = value;
        }

        protected Schedule()
        {

        }

        public Schedule(string name, DateTime scheduleStart, DateTime scheduleStop)
        {
            if (IsNullOrEmpty(name))
            {
                throw  new InvalidValueException("Name must not be empty!");
            }

            if (DateTime.Compare(scheduleStart, scheduleStop) >= 0)
            {
                throw  new DateTimeRuleException("Schedule start date must be before end date!");
            }
            _name = name;
            _scheduleStart = scheduleStart;
            _scheduleStop = scheduleStop;
        }

        public override string ToString()
        {
            return _name;
        }

        protected bool Equals(Schedule other)
        {
            return string.Equals(_name, other._name) && _scheduleStart.Equals(other._scheduleStart)
                                                     && _scheduleStop.Equals(other._scheduleStop);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Schedule) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_name != null ? _name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _scheduleStart.GetHashCode();
                hashCode = (hashCode * 397) ^ _scheduleStop.GetHashCode();
                return hashCode;
            }
        }
    }
}