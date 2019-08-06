using DesignPattern.AbstractFactory.BaseSet;

namespace DesignPattern.AbstractFactory.TerranSet
{
    public class Terran : Race
    {
        public override MainCenterBuilding CreateMainCenterBuilding()
        {
            return new CommandCenter();
        }

        public override PopulationBuilding CreatePopulationBuilding()
        {
            return new SupplyDepot();
        }
    }
}