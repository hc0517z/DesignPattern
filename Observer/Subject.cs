using System.Collections.Generic;

namespace DesignPattern.Observer
{
    public abstract class Subject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected void NotifyObservers()
        {
            foreach (var observer in observers) observer.Update();
        }
    }
}