using System;

namespace BaseLib.ViewInterfaces
{
    public interface IAddScheduleView : IView
    {
        string ScheduleName { get; }
        DateTime ScheduleStartTime { get; }
        DateTime ScheduleEndTime { get; }
    }
}