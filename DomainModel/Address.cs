using System;
using static System.String;

namespace DomainModel
{
    public class Address
    {
        private string _city;
        private string _street;
        private int _zipCode;

        public virtual string City
        {
            get => _city;
            set => _city = value;
        }

        public virtual string Street
        {
            get => _street;
            set => _street = value;
        }

        public virtual int ZipCode
        {
            get => _zipCode;
            set => _zipCode = value;
        }

        public Address(string city, string street, int zipCode)
        {
            if (IsNullOrEmpty(city))
            {
                throw new InvalidValueException("City must not be empty!");
            }

            if (IsNullOrEmpty(street))
            {
                throw new InvalidValueException("Street must not be empty!");
            }


            _city = city;
            _street = street;
            _zipCode = zipCode;
        }

        protected Address()
        {

        }

        public override string ToString()
        {
            return _city + ", " + _street + ", " + _zipCode;
        }

        protected bool Equals(Address other)
        {
            return String.Equals(_city, other._city) && String.Equals(_street, other._street) &&
                   _zipCode == other._zipCode;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Address) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_city != null ? _city.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_street != null ? _street.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _zipCode;
                return hashCode;
            }
        }
    }
}