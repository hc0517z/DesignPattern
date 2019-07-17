namespace DesignPattern.Command
{
    public class Button
    {
        private ICommand command;

        public Button(ICommand command)
        {
            SetCommand(command);
        }

        public void SetCommand(ICommand newCommand)
        {
            command = newCommand;
        }

        public void Pressed()
        {
            command.Execute();
        }
    }
}