using System.Collections.Generic;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tests = new List<ITest>
            {
                new Strategy.Client(),
                new Command.Client(),
                new Observer.Client(),
                new Decorator.Client(),
                new Visitor.Client(),
                new TemplateMethod.Client(),
            };

            tests.ForEach(test => test.Run());
        }
    }
}