namespace visitor
{
    public class CssClassVisitor : IVisitor
    {
        private string _classAtr = " class='visitor'";

        public void Visit(HtmlElement element)
        {
            int endBracketIndex = GetEndBracketIndex(element.StartTag);

            element.StartTag = element.StartTag.Insert(endBracketIndex, _classAtr);
        }

        public void Visit(HtmlParentElement parentElement)
        {
            int endBracketIndex = GetEndBracketIndex(parentElement.StartTag);

            parentElement.StartTag = parentElement.StartTag.Insert(endBracketIndex, _classAtr);
        }

        private int GetEndBracketIndex(string htmlTag)
        {
            return htmlTag.IndexOf('>');
        }
    }
}