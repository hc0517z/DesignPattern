namespace DesignPattern.Adapter.SocketAdapter
{
    public interface ISocketAdapter
    {
        Volt Get120Volt();
        Volt Get12Volt();
        Volt Get3Volt();
    }
}