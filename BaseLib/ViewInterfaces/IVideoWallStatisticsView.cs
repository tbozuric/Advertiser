using System;
using DomainModel;

namespace BaseLib.ViewInterfaces
{
    public interface IVideoWallStatisticsView : IView
    {
        Address Location { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
    }
}