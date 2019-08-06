using System;

namespace DesignPattern.Facade
{
    public class Client : ITest
    {
        public void Run()
        {
            var unitCreatable = new UnitCreatable();

            void WriteCreatableUnit(bool isCreatable)
            {
                Console.WriteLine(isCreatable ? "유닛 생성 가능!" : "유닛 생성 불가능!");
            }

            WriteCreatableUnit(unitCreatable.IsUnitCreatable(50, 30, 2));
            WriteCreatableUnit(unitCreatable.IsUnitCreatable(50, 130, 2));
            WriteCreatableUnit(unitCreatable.IsUnitCreatable(50, 30, 5));
        }
    }
}