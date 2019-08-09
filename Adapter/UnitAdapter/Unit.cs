namespace DesignPattern.Adapter.UnitAdapter
{
    public class Unit : NewUnit
    {
        private OldUnit adaptee = new OldUnit();
        
        public override void Move()
        {
            adaptee.MoveToPoint();
        }

        public override void Stop()
        {
            adaptee.StopMove();
        }
    }
}