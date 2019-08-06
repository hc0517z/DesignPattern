using System;

namespace DesignPattern.Factory
{
    public class Client : ITest
    {
        public void Run()
        {
            var tomatoPizza = Pizza.Factory.CreatePizza(PizzaType.Tomato);
            Console.WriteLine(tomatoPizza.GetName());
            var pepperoniPizza = Pizza.Factory.CreatePizza(PizzaType.Pepperoni);
            Console.WriteLine(pepperoniPizza.GetName());
        }
    }
}