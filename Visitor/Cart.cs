using System;
using System.Collections.Generic;

namespace DesignPattern.Visitor
{
    public class Cart : IElement
    {
        private readonly List<IElement> elements = new List<IElement>();

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Cart가 준비되었습니다.");
            visitor.Visit(this);

            foreach (var element in elements) element.Accept(visitor);
        }

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }
    }
}