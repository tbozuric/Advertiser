namespace BaseLib.ViewInterfaces
{
    public interface IAddVideoWallView : IView
    {
        short Width { get; }
        short Height { get; }

        string City { get; }

        string Street { get; }

        short ZipCode { get; }
    }
}