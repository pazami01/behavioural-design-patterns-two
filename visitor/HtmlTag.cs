using System.Collections.Generic;

namespace visitor
{
    public abstract class HtmlTag : IElement
    {
        public abstract string TagName { get; set; }

        public abstract string StartTag { get; set; }

        public abstract string EndTag { get; set; }

        public string TagBody { get; set; }

        public virtual void AddChildTag(HtmlTag htmlTag)
        {
            throw new System.NotImplementedException();
        }

        public virtual void RemoveChildTag(HtmlTag htmlTag)
        {
            throw new System.NotImplementedException();
        }

        public virtual List<HtmlTag> GetChildren()
        {
            throw new System.NotImplementedException();
        }

        public abstract void GenerateHtml();

        public abstract void Accept(IVisitor visitor);
    }
}