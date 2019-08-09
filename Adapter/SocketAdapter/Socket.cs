namespace DesignPattern.Adapter.SocketAdapter
{
    public class Socket
    {
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}