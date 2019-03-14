using DomainModel;

namespace BaseLib.ViewInterfaces
{
    public interface IShowServicesForVideoWallView<T> : IShowView<T>

    {
        Address Location { get; }
    }
}