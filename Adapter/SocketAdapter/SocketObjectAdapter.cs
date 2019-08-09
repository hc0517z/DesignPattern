namespace DesignPattern.Adapter.SocketAdapter
{
    public class SocketObjectAdapter : ISocketAdapter
    {
        private Socket socket = new Socket();
        
        public Volt Get120Volt()
        {
            return socket.GetVolt();
        }

        public Volt Get12Volt()
        {
            var v = socket.GetVolt();
            return ConvertVolt(v, 10);
        }

        public Volt Get3Volt()
        {
            var v = socket.GetVolt();
            return ConvertVolt(v, 40);
        }

        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.Volts / i);
        }
    }
}