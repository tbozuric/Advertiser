using System.Text.RegularExpressions;
using static System.String;

namespace DomainModel
{
    public class Person
    {
        protected string PersonName;
        protected string PersonSurname;
        protected string PersonOib;

        public virtual int Id { get; set; }

        public virtual string Name
        {
            get => PersonName;
            set => PersonName = value;
        }

        public virtual string Surname
        {
            get => PersonSurname;
            set => PersonSurname = value;
        }

        public virtual string Oib
        {
            get => PersonOib;
            set => PersonOib = value;
        }

        public Person(string oib, string name, string surname)
        {
            CheckParameter(oib, "Oib");
            CheckParameter(name, "Name");
            CheckParameter(surname, "Surname");

            if (IsNullOrEmpty(oib) || !Regex.IsMatch(oib, @"^[\p{N}]+$") || oib.Length != 11)
            {
                throw new InvalidPersonDataException("OIB must consist of 11 digits.");
            }

            if (IsNullOrEmpty(surname) || !Regex.IsMatch(surname, @"^[\p{L}]+$"))
            {
                throw new InvalidPersonDataException("Surname must consist of letters.");
            }

            if (IsNullOrEmpty(name) || !Regex.IsMatch(name, @"^[\p{L}]+$"))
            {
                throw new InvalidPersonDataException("Name must consist of letters.");
            }

            PersonOib = oib;
            PersonName = name;
            PersonSurname = surname;
        }

        private static void CheckParameter(string parameter, string text)
        {
            if (IsNullOrEmpty(parameter))
            {
                throw new InvalidPersonDataException(text + " must not be empty!");
            }
        }

        protected Person()
        {
        }

        public override string ToString()
        {
            return PersonOib + ", " + PersonSurname + ", " + PersonName;
        }

        protected bool Equals(Person other)
        {
            return string.Equals(PersonOib, other.PersonOib);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode()
        {
            return (PersonOib != null ? PersonOib.GetHashCode() : 0);
        }
    }
}