using System;

namespace DesignPattern.Decorator
{
    public class TrafficDecorator : DisplayDecorator
    {
        public TrafficDecorator(Display decoratedDisplay) : base(decoratedDisplay)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DrawTraffic();
        }

        private void DrawTraffic()
        {
            Console.WriteLine("\t교통량 표시");
        }
    }
}