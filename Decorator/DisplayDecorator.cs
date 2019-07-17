namespace DesignPattern.Decorator
{
    public abstract class DisplayDecorator : Display
    {
        private Display decoratedDisplay;

        protected DisplayDecorator(Display decoratedDisplay)
        {
            this.decoratedDisplay = decoratedDisplay;
        }

        public override void Draw()
        {
            decoratedDisplay.Draw();
        }
    }
}