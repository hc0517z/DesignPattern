using System;

namespace DesignPattern.Visitor
{
    public class Client : ITest
    {
        public void Run()
        {
            Cart cart = new Cart();
            cart.AddElement(new Fruits());
            cart.AddElement(new Milk());
            
            Shopper shopper = new Shopper();
            cart.Accept(shopper);
        }
    }
}