using System;

namespace DesignPattern.Adapter.UnitAdapter
{
    public class OldUnit
    {
        public void MoveToPoint()
        {
            Console.WriteLine("Old Unit Moved !");
        }

        public void StopMove()
        {
            Console.WriteLine("Old Unit Stopped !");
        }
    }
}