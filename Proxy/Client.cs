using System;

namespace DesignPattern.Proxy
{
    public class Client : ITest
    {
        public void Run()
        {
            Console.WriteLine("Client: Executing the client code with a real subject:");
            var realSubject = new RealSubject();
            ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            var proxy = new Proxy(realSubject);
            ClientCode(proxy);
        }

        private void ClientCode(ISubject subject)
        {
            //....
            
            subject.Request();
            
            //....
        }
    }
}