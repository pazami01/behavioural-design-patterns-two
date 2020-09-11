using System;

namespace visitor
{
    public static class TestVisitorPattern
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Before visitor......... \n");

            HtmlTag parentTag = new HtmlParentElement("<html>");
            parentTag.StartTag = "<html>";
            parentTag.EndTag = "</html>";

            HtmlTag p1 = new HtmlParentElement("<body>");
            p1.StartTag = "<body>";
            p1.EndTag = "</body>";

            parentTag.AddChildTag(p1);

            HtmlTag child1 = new HtmlElement("<p>");
            child1.StartTag = "<p>";
            child1.EndTag = "</p>";
            child1.TagBody = "Testing html tag library";
            p1.AddChildTag(child1);

            child1 = new HtmlElement("<p>") {StartTag = "<p>", EndTag = "</p>", TagBody = "Paragraph 2"};
            p1.AddChildTag(child1);

            parentTag.GenerateHtml();

            Console.WriteLine("\nAfter visitor....... \n");

            IVisitor cssClass = new CssClassVisitor();
            IVisitor style = new StyleVisitor();

            parentTag = new HtmlParentElement("<html>") { StartTag = "<html>", EndTag = "</html>" };

            parentTag.Accept(style);
            parentTag.Accept(cssClass);

            p1 = new HtmlParentElement("<body>") { StartTag = "<body>", EndTag = "</body>" };
            p1.Accept(style);
            p1.Accept(cssClass);

            parentTag.AddChildTag(p1);

            child1 = new HtmlElement("<p>") { StartTag = "<p>", EndTag = "</p>", TagBody = "Testing html tag library" };
            child1.Accept(style);
            child1.Accept(cssClass);

            p1.AddChildTag(child1);

            child1 = new HtmlElement("<p>") { StartTag = "<p>", EndTag = "</p>", TagBody = "Paragraph 2" };
            child1.Accept(style);
            child1.Accept(cssClass);

            p1.AddChildTag(child1);

            parentTag.GenerateHtml();
        }
    }
}