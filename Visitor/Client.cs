namespace DesignPattern.Visitor
{
    public class Client : ITest
    {
        public void Run()
        {
            var cart = new Cart();
            cart.AddElement(new Fruits());
            cart.AddElement(new Milk());

            var shopper = new Shopper();
            cart.Accept(shopper);
        }
    }
}