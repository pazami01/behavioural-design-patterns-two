using System.Collections.Generic;

namespace visitor
{
    public class HtmlParentElement : HtmlTag
    {
        private List<HtmlTag> _htmlTags;

        public HtmlParentElement(string tagName)
        {
            _htmlTags = new List<HtmlTag>();
            TagName = tagName;
            TagBody = "";
            StartTag = "";
            EndTag = "";
        }

        public override string TagName { get; set; }
        public override string StartTag { get; set; }
        public override string EndTag { get; set; }

        public override void AddChildTag(HtmlTag htmlTag) => _htmlTags.Add(htmlTag);

        public override void RemoveChildTag(HtmlTag htmlTag) => _htmlTags.Remove(htmlTag);

        public override void GenerateHtml()
        {
            System.Console.WriteLine(StartTag);

            foreach (var htmlTag in _htmlTags)
            {
                htmlTag.GenerateHtml();
            }

            System.Console.WriteLine(EndTag);
        }

        public override void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}