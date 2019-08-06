using System;

namespace DesignPattern.Strategy
{
    public class Client : ITest
    {
        public void Run()
        {
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