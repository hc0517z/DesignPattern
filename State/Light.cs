namespace DesignPattern.State
{
    public class Light
    {
        private IState state = new StateOff();
        public IState State
        {
            set { state = value; }
        }

        public void OnButtonPushed()
        {
            state.OnButtonPushed(this);
        }
        
        public void OffButtonPushed()
        {
            state.OffButtonPushed(this);
        }
    }
}