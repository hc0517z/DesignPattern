using DesignPattern.AbstractFactory.BaseSet;

namespace DesignPattern.AbstractFactory.ProtossSet
{
    public class Protoss : Race
    {
        public override MainCenterBuilding CreateMainCenterBuilding()
        {
            return new Nexus();
        }

        public override PopulationBuilding CreatePopulationBuilding()
        {
            return new Pylon();
        }
    }
}