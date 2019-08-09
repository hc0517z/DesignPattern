using System;

namespace DesignPattern.Adapter.UnitAdapter
{
    public class NewUnit
    {
        public virtual void Move()
        {
            Console.WriteLine("New Unit Moved !");
        }

        public virtual void Stop()
        {
            Console.WriteLine("New Unit Stopped !");
        }
    }
}