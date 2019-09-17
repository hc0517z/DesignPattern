using System;

namespace DesignPattern.State
{
    public class StateSleeping : IState
    {
        public static StateSleeping Instance { get; } = new StateSleeping();

        public void OnButtonPushed(Light light)
        {
            Console.WriteLine("more brightly!");
            light.State = StateOn.Instance;
        }

        public void OffButtonPushed(Light light)
        {
            Console.WriteLine("Turn off this light");
            light.State = StateOff.Instance;
        }
    }
}