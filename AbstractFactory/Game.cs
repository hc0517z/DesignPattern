using DesignPattern.AbstractFactory.BaseSet;

namespace DesignPattern.AbstractFactory
{
    public class Game
    {
        private readonly MainCenterBuilding mainCenterBuilding;
        private readonly PopulationBuilding populationBuilding;

        public Game(Race race)
        {
            mainCenterBuilding = race.CreateMainCenterBuilding();
            populationBuilding = race.CreatePopulationBuilding();
        }

        public void Show()
        {
            populationBuilding.Interact(mainCenterBuilding);
        }
    }
}