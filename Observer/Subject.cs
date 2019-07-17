using System.Collections.Generic;

namespace DesignPattern.Observer
{
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

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
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}