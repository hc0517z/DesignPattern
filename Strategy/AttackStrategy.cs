using System;

namespace DesignPattern.Strategy
{
    public interface IAttackStrategy
    {
        void Attack();
    }

    public class MissileStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("I have Missile.");
        }
    }

    public class PunchStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("I have strong punch.");
        }
    }
}