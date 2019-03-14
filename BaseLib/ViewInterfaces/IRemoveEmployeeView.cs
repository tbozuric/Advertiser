using DomainModel;

namespace BaseLib.ViewInterfaces
{
    public interface IRemoveEmployeeView : IView
    {
        Employee EmployeeData { get; }
    }
}