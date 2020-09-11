namespace visitor
{
    public interface IVisitor
    {
        public void Visit(HtmlElement element);
        public void Visit(HtmlParentElement parentElement);
    }
}