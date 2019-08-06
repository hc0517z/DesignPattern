using System;

namespace DesignPattern.TemplateMethod
{
    public class Client : ITest
    {
        public void Run()
        {
            Car porter = new ManualOperationCar();
            Car bmw = new AutomaticOperationCar();
            
            porter.PlayWithOwner();
            Console.WriteLine();
            bmw.PlayWithOwner();
        }
    }
}