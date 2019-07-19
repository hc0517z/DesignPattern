using System;

namespace DesignPattern.TemplateMethod
{
    public class Client : ITest
    {
        public void Run()
        {
            Console.WriteLine("\n");
            Console.WriteLine("[ Run Template Method Pattern Test Client ]");
            
            Car porter = new ManualOperationCar();
            Car bmw = new AutomaticOperationCar();
            
            porter.PlayWithOwner();
            Console.WriteLine();
            bmw.PlayWithOwner();
        }
    }
}