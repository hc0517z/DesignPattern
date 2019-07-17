namespace DesignPattern.Strategy
{
    public abstract class Robot
    {
        private IAttackStrategy attackStrategy;
        private IMovingStrategy movingStrategy;
        private readonly string name;

        protected Robot(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void Attack()
        {
            attackStrategy.Attack();
        }

        public void Move()
        {
            movingStrategy.Move();
        }

        public void SetAttackStrategy(IAttackStrategy attackStrategy)
        {
            this.attackStrategy = attackStrategy;
        }

        public void SetMovingStrategy(IMovingStrategy movingStrategy)
        {
            this.movingStrategy = movingStrategy;
        }
    }
    
    public class TaekwonV : Robot
    {
        public TaekwonV(string name) : base(name)
        {
        }
    }
    
    public class Atom : Robot
    {
        public Atom(string name) : base(name)
        {
        }
    }
}