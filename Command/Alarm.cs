using System;

namespace DesignPattern.Command
{
    public class Alarm
    {
        public void Start()
        {
            Console.WriteLine("Alarming");
        }
    }
    
    public class AlarmStartCommand : ICommand
    {
        private Alarm alarm;

        public AlarmStartCommand(Alarm alarm)
        {
            this.alarm = alarm;
        }

        public void Execute()
        {
            alarm.Start();
        }
    }
}