using System;
using DesignPattern.AbstractFactory.BaseSet;

namespace DesignPattern.AbstractFactory.TerranSet
{
    public class SupplyDepot : PopulationBuilding
    {
        public override void Interact(MainCenterBuilding mainCenterBuilding)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + mainCenterBuilding.GetType().Name);
        }
    }
}