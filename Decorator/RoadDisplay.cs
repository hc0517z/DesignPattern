using System;

namespace DesignPattern.Decorator
{
    public class RoadDisplay : Display
    {
        public override void Draw()
        {
            Console.WriteLine("기본 도로 표시");
        }
    }
}