namespace DesignPattern.Visitor
{
    public interface IVisitor
    {
        void Visit(Cart cart);
        void Visit(Fruits fruits);
        void Visit(Milk milk);
    }
}