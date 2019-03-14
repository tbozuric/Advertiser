using System;

namespace BaseLib.ViewInterfaces
{
    public interface IEmployeeServicesStatisticsView : IView
    {
        string Oib { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
    }
}