using System;
using System.Collections.Generic;
using DesignPattern.Adapter.SocketAdapter;
using DesignPattern.Adapter.UnitAdapter;

namespace DesignPattern.Adapter
{
    public class Client : ITest
    {
        public void Run()
        {
            RunToUnit();
            Console.WriteLine(new string('-', 50));
            RunToSocket();
        }

        private void RunToUnit()
        {
            var listUnit = new List<NewUnit> {new NewUnit(), new Unit()};
            foreach (var unit in listUnit)
            {
                unit.Move();
                unit.Stop();
            }
        }

        private void RunToSocket()
        {
            var listSocket = new List<ISocketAdapter> {new SocketClassAdapter(), new SocketObjectAdapter()};
            foreach (ISocketAdapter socketAdapter in listSocket)
            {
                Console.WriteLine("[{0}]", socketAdapter.GetType().Name);
                Console.WriteLine("{0} volts", socketAdapter.Get3Volt().Volts);
                Console.WriteLine("{0} volts", socketAdapter.Get12Volt().Volts);
                Console.WriteLine("{0} volts", socketAdapter.Get120Volt().Volts);
            }
        }
    }
}