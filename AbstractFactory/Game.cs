using DesignPattern.AbstractFactory.BaseSet;

namespace DesignPattern.AbstractFactory
{
    public class Game
    {
        private MainCenterBuilding mainCenterBuilding;
        private PopulationBuilding populationBuilding;

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