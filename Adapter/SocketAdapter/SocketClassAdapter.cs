namespace DesignPattern.Adapter.SocketAdapter
{
    public class SocketClassAdapter : Socket, ISocketAdapter
    {
        public Volt Get120Volt()
        {
            return GetVolt();
        }

        public Volt Get12Volt()
        {
            var v = GetVolt();
            return ConvertVolt(v, 10);
        }

        public Volt Get3Volt()
        {
            var v = GetVolt();
            return ConvertVolt(v, 40);
        }

        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.Volts / i);
        }
    }
}