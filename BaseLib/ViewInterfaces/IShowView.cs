using System.Collections.Generic;

namespace BaseLib.ViewInterfaces
{
    public interface IShowView<T> : IObserver
    {
        void ShowModal(IMainController inMainController, IList<T> inList);
    }
}