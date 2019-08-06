using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
                new Factory.Client(),
                new AbstractFactory.Client(),
            };
            
            tests.ForEach(delegate(ITest test)
            {
                Console.WriteLine(new string('=', 50));
                var testType = test.GetType().Namespace;
                Console.WriteLine(testType + " TEST");
                Console.WriteLine(new string('=', 50));
                test.Run();
                Console.WriteLine();
            });
        }
    }
}