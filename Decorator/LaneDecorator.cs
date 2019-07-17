using System;

namespace DesignPattern.Decorator
{
    public class LaneDecorator : DisplayDecorator
    {
        public LaneDecorator(Display decoratedDisplay) : base(decoratedDisplay)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DrawLane();
        }

        private void DrawLane()
        {
            Console.WriteLine("\t차선 표시");
        }
    }
}