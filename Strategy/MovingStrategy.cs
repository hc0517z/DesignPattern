using System;

namespace DesignPattern.Strategy
{
    public interface IMovingStrategy
    {
        void Move();
    }

    public class FlyingStrategy : IMovingStrategy
    {
        public void Move()
        {
            Console.WriteLine("I can fly.");
        }
    }
    
    public class WalkingStrategy : IMovingStrategy
    {
        public void Move()
        {
            Console.WriteLine("I can only walk.");
        }
    }
}