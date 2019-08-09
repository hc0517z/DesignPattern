namespace DesignPattern.Adapter.SocketAdapter
{
    public class Volt
    {
        private int volts;

        public Volt(int volts)
        {
            this.volts = volts;
        }

        public int Volts
        {
            get { return volts; }
            set { volts = value; }
        }
    }
}