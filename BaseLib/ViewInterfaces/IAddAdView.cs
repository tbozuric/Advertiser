namespace BaseLib.ViewInterfaces
{
    public interface IAddAdView : IView
    {
        string AdName { get; }
        string Content { get; }
    }
}