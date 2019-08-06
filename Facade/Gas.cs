namespace DesignPattern.Facade
{
    public class Gas
    {
        private int gas = 100;

        public bool IsEnoughGas(int unitGasCost)
        {
            return unitGasCost <= gas;
        }
    }
}