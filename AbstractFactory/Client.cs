using DesignPattern.AbstractFactory.ProtossSet;
using DesignPattern.AbstractFactory.TerranSet;
using DesignPattern.AbstractFactory.ZergSet;

namespace DesignPattern.AbstractFactory
{
    public class Client : ITest
    {
        public void Run()
        {
            var gameWithTerran = new Game(new Terran());
            var gameWithProtoss = new Game(new Protoss());
            var gameWithZerg = new Game(new Zerg());

            gameWithTerran.Show();
            gameWithProtoss.Show();
            gameWithZerg.Show();
        }
    }
}