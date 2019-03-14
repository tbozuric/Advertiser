using System.Collections.Generic;
using DomainModel;

namespace BaseLib.ViewInterfaces
{
    public interface IManageVideoWallsView : IObserver
    {
        Address Location { get; }

        void ShowModal(IMainController inMainController, IList<VideoWall> inList);
    }
}