using System;

namespace DesignPattern.Proxy
{
    public class Proxy : ISubject
    {
        private RealSubject realSubject;

        public Proxy(RealSubject realSubject)
        {
            this.realSubject = realSubject;
        }

        public void Request()
        {
            if (CheckAccess())
            {
                if (realSubject == null) realSubject = new RealSubject();
                realSubject.Request();
                LogAccess();
            }
        }

        public bool CheckAccess()
        {
            // Som real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}