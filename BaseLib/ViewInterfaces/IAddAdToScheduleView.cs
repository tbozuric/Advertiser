using System;
using DomainModel;

namespace BaseLib.ViewInterfaces
{
    public interface IAddAdToScheduleView : IView
    {
        Ad Ad { get; }
        DateTime StartBroadcast { get; }
        DateTime EndBroadcast { get; }
    }
}