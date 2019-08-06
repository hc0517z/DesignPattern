using System;

namespace DesignPattern.Command
{
    public class Client : ITest
    {
        public void Run()
        {
            var lampOnCommand = new LampOnCommand(new Lamp());
            var alarmStartCommand = new AlarmStartCommand(new Alarm());

            var button1 = new Button(lampOnCommand);
            button1.Pressed();

            var button2 = new Button(alarmStartCommand);
            button2.Pressed();
            button2.SetCommand(lampOnCommand);
            button2.Pressed();
        }
    }
}