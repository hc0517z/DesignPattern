using System.Collections.Generic;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tests = new List<ITest>
            {
                new Strategy.TestClient(), 
                new Command.TestClient(),
            };

            tests.ForEach(test => test.Run());
        }
    }
}