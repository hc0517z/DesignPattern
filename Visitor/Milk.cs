using System;

namespace DesignPattern.Visitor
{
    public class Milk : IElement
    {
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("우유가 준비되었습니다.");
            visitor.Visit(this);
        }
    }
}