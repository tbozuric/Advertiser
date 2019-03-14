using System.Collections.Generic;
using DomainModel;

namespace BaseLib.ViewInterfaces
{
    public interface IManageSchedulesView : IObserver
    {
        string NameOfSchedule { get; }

        void ShowModal(IMainController inMainController, IList<Schedule> inList);
    }
}