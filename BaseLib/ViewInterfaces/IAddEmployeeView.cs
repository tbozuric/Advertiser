namespace BaseLib.ViewInterfaces
{
    public interface IAddEmployeeView : IView
    {
        string Oib { get; }
        string Surname { get; }
        string Name { get; }
    }
}