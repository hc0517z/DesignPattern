namespace DesignPattern.Facade
{
    public class UnitCreatable
    {
        Mineral mineral = new Mineral();
        Gas gas = new Gas();
        UnitLimit unitLimit = new UnitLimit();

        public bool IsUnitCreatable(int unitMineralCost, int unitGasCost, int unitLimitCost)
        {
            if (!mineral.IsEnoughMineal(unitMineralCost))
                return false;
            if (!gas.IsEnoughGas(unitGasCost))
                return false;
            if (!unitLimit.IsEnoughLimit(unitLimitCost))
                return false;

            return true;
        }
    }
}