namespace visitor
{
    public interface IElement
    {
        public void Accept(IVisitor visitor);
    }
}