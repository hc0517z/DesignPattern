using System;
using System.Collections.Generic;

namespace DesignPattern.Visitor
{
    public class Cart : IElement
    {
        List<IElement> elements = new List<IElement>();

        public Cart()
        {
            
        }

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }
        
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Cart가 준비되었습니다.");
            visitor.Visit(this);

            foreach (IElement element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}