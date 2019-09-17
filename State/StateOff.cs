using System;

namespace DesignPattern.State
{
    public class StateOff : IState
    {
        public static StateOff Instance { get; } = new StateOff();

        public void OnButtonPushed(Light light)
        {
            Console.WriteLine("Turn on");
            light.State = StateOn.Instance;
        }

        public void OffButtonPushed(Light light)
        {
            Console.WriteLine("Do nothing");
        }
    }
}