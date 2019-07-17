using System;

namespace DesignPattern.Command
{
    public class Lamp
    {
        public void TurnOn()
        {
            Console.WriteLine("Lamp On");
        }
    }
    
    public class LampOnCommand : ICommand
    {
        private Lamp lamp;

        public LampOnCommand(Lamp lamp)
        {
            this.lamp = lamp;
        }

        public void Execute()
        {
            lamp.TurnOn();
        }
    }
}