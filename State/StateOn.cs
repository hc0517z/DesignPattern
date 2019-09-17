using System;

namespace DesignPattern.State
{
    public class StateOn : IState
    {
        public static StateOn Instance { get; } = new StateOn();

        public void OnButtonPushed(Light light)
        {
            Console.WriteLine("Do sleeping");
            light.State = StateSleeping.Instance;
        }

        public void OffButtonPushed(Light light)
        {
            Console.WriteLine("Turn off");
            light.State = StateOff.Instance;
        }
    }
}