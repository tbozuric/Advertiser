using System.Collections.Generic;

namespace BaseLib
{
    public abstract class Subject
    {
        readonly List<IObserver> _listObservers = new List<IObserver>();

        public void Attach(IObserver obs)
        {
            _listObservers.Add(obs);
        }

        public void Delete(IObserver obs)
        {
            _listObservers.Remove(obs);
        }

        public void NotifyObservers()
        {
            foreach (var obs in _listObservers)
            {
                obs.UpdateView();
            }
        }
    }
}