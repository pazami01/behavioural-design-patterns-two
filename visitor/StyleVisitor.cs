namespace visitor
{
    public class StyleVisitor : IVisitor
    {
        public void Visit(HtmlElement element)
        {
            string styleStr = " style='width:46px;'";
            int endBracketIndex = GetEndBracketIndex(element.StartTag);

            element.StartTag = element.StartTag.Insert(endBracketIndex, styleStr);
        }

        public void Visit(HtmlParentElement parentElement)
        {
            string styleStr = " style='width:58px;'";
            int endBracketIndex = GetEndBracketIndex(parentElement.StartTag);

            parentElement.StartTag = parentElement.StartTag.Insert(endBracketIndex, styleStr);
        }

        private int GetEndBracketIndex(string htmlTag)
        {
            return htmlTag.IndexOf('>');
        }
    }
}