using System;

namespace DomainModel
{
  

    [Serializable]
    public class AdNullReferenceException : Exception
    {
        public AdNullReferenceException(string message) : base(message)
        {
        }
    }

    [Serializable]
    public class VideoWallNullReferenceException : Exception
    {
        public VideoWallNullReferenceException(string message) : base(message)
        {
        }
    }

 
    [Serializable]
    public class InvalidPersonDataException : Exception
    {
        public InvalidPersonDataException(string message) : base(message)
        {
        }
    }

    [Serializable]
    public class AddressNullReferenceException : Exception
    {
        public AddressNullReferenceException(string message) : base(message)
        {
        }
    }

    [Serializable]
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) : base(message)
        {
        }
    }

    [Serializable]
    public class DateTimeRuleException : Exception
    {
        public DateTimeRuleException(string message) : base(message)
        {
        }
    }

    [Serializable]
    public class InvalidValueException : Exception
    {
        public InvalidValueException(string message) : base(message)
        {
        }
    }
}