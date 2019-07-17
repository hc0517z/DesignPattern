using System;

namespace DesignPattern.Decorator
{
    public class CrossingDecorator : DisplayDecorator
    {
        public CrossingDecorator(Display decoratedDisplay) : base(decoratedDisplay)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DrawCrossing();
        }

        private void DrawCrossing()
        {
            Console.WriteLine("\t교차로 표시");
        }
    }
}