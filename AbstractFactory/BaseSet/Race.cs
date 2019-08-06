namespace DesignPattern.AbstractFactory.BaseSet
{
    public abstract class Race
    {
        public abstract MainCenterBuilding CreateMainCenterBuilding();
        public abstract PopulationBuilding CreatePopulationBuilding();
    }
}