using System;

namespace DesignPattern.Factory
{
    public enum PizzaType
    {
        Tomato,
        Pepperoni
    };
    
    public class PizzaFactory
    {
        public Pizza CreatePizza(PizzaType typeToPizza)
        {
            switch (typeToPizza)
            {
                case PizzaType.Tomato:
                    return new TomatoPizza();
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeToPizza), typeToPizza, null);
            }
        }
    }
}