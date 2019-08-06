namespace DesignPattern.Facade
{
    public class Mineral
    {
        private int mineral = 100;
        public bool IsEnoughMineal(int unitMineralCost)
        {
            return unitMineralCost <= mineral;
        }
    }
}