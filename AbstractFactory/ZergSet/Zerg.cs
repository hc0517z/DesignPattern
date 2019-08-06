using DesignPattern.AbstractFactory.BaseSet;

namespace DesignPattern.AbstractFactory.ZergSet
{
    public class Zerg : Race
    {
        public override MainCenterBuilding CreateMainCenterBuilding()
        {
            return new Hatchery();
        }

        public override PopulationBuilding CreatePopulationBuilding()
        {
            return new Overlord();
        }
    }
}