using DomainModel;

namespace BaseLib.ViewInterfaces
{
    public interface IRemoveVideoWallView : IView
    {
        Address WallLocation { get; }
    }
}