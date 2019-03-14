using System;

namespace BaseLib
{
    [Serializable]
    public class VideoWallAtLocationAlreadyExistsException : Exception
    {
        public VideoWallAtLocationAlreadyExistsException(string message) : base(message)
        {
        }
    }

    [Serializable]
    public class AdWithNameAlreadyExistsException : Exception
    {
    }

    [Serializable]
    public class ScheduleWithNameAlreadyExistsException : Exception
    {
    }


    [Serializable]
    public class EmployeeWithOibAlreadyExistsException : Exception
    {
        public EmployeeWithOibAlreadyExistsException(string message) : base(message)
        {
        }
    }
}