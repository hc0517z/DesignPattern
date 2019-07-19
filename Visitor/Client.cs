using System;

namespace DesignPattern.Visitor
{
    public class Client : ITest
    {
        public void Run()
        {
            Console.WriteLine("\n");
            Console.WriteLine("[ Run Visitor Pattern Test Client ]");
            
            Cart cart = new Cart();
            cart.AddElement(new Fruits());
            cart.AddElement(new Milk());
            
            Shopper shopper = new Shopper();
            cart.Accept(shopper);
        }
    }
}