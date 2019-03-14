using System;
using DomainModel;

namespace BaseLib.ViewInterfaces
{
    public interface IAddServiceView : IView
    {
        DateTime ServiceStartTime { get; }
        DateTime ServiceEndTime { get; }
        Employee Employee { get; }
        FailureType FailureType { get; }
        Address VideoWallLocation { get; }

        void SnoozeVideoWall(VideoWall videoWall);
    }
}