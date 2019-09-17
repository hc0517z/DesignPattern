namespace DesignPattern.State
{
    public class Client : ITest
    {
        public void Run()
        {
            var light = new Light();
            
            light.OffButtonPushed();
            light.OnButtonPushed();
            light.OffButtonPushed();
            light.OffButtonPushed();
            light.OnButtonPushed();
            light.OnButtonPushed();
            light.OffButtonPushed();
            light.OnButtonPushed();
            light.OnButtonPushed();
            light.OnButtonPushed();
            light.OffButtonPushed();
        }
    }
}