using System;

namespace DesignPattern.Factory
{
    public abstract class Pizza
    {
        private static readonly Lazy<PizzaFactory> pFactory = new Lazy<PizzaFactory>();

        public static PizzaFactory Factory
        {
            get { return pFactory.Value; }
        }

        public abstract string GetName();
    }

    public class TomatoPizza : Pizza
    {
        public override string GetName()
        {
            return "TomatoPizza";
        }
    }

    public class PepperoniPizza : Pizza
    {
        public override string GetName()
        {
            return "PepperoniPizza";
        }
    }
}