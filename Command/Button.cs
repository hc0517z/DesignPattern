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
            this.command = newCommand;
        }

        public void Pressed()
        {
            command.Execute();
        }
    }
}