using System.Collections.Generic;
using DesignPattern.Strategy;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tests = new List<ITest>
            {
                new TestClient(),
                new Command.TestClient()
            };

            tests.ForEach(test => test.Run());
        }
    }
}