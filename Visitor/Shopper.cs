using System;

namespace DesignPattern.Visitor
{
    public class Shopper : IVisitor
    {
        public void Visit(Cart cart)
        {
            Console.WriteLine("Cart를 이용합니다.");
        }

        public void Visit(Fruits fruits)
        {
            Console.WriteLine("과일을 넣었습니다.");
        }

        public void Visit(Milk milk)
        {
            Console.WriteLine("우유를 넣었습니다.");
        }
    }
}