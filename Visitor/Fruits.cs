using System;

namespace DesignPattern.Visitor
{
    public class Fruits : IElement
    {
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("과일이 준비되었습니다.");
            visitor.Visit(this);
        }
    }
}