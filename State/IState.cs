namespace DesignPattern.State
{
    public interface IState
    {
        void OnButtonPushed(Light light);
        void OffButtonPushed(Light light);
    }
}