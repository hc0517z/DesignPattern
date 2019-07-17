using System;

namespace DesignPattern.Strategy
{
    public class TestClient : ITest
    {
        public void Run()
        {
            Console.WriteLine("\n");
            Console.WriteLine("[ Run Strategy pattern TestClient ]");

            var taekwonV = new TaekwonV("TaekwonV");
            var atom = new Atom("Atom");

            taekwonV.SetMovingStrategy(new WalkingStrategy());
            taekwonV.SetAttackStrategy(new MissileStrategy());

            atom.SetMovingStrategy(new FlyingStrategy());
            atom.SetAttackStrategy(new PunchStrategy());

            Console.WriteLine("My name is " + taekwonV.GetName());
            taekwonV.Move();
            taekwonV.Attack();

            Console.WriteLine();
            Console.WriteLine("My name is " + atom.GetName());
            atom.Move();
            atom.Attack();
        }
    }
}