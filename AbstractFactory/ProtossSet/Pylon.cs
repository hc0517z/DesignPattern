using System;
using DesignPattern.AbstractFactory.BaseSet;

namespace DesignPattern.AbstractFactory.ProtossSet
{
    public class Pylon : PopulationBuilding
    {
        public override void Interact(MainCenterBuilding mainCenterBuilding)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + mainCenterBuilding.GetType().Name);
        }
    }
}