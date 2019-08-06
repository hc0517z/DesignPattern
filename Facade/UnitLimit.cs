namespace DesignPattern.Facade
{
    public class UnitLimit
    {
        private int limit = 3;

        public bool IsEnoughLimit(int unitLimitCost)
        {
            return unitLimitCost <= limit;
        }
    }
}