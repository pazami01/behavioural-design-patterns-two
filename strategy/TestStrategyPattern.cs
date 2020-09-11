using System;

namespace strategy
{
    public static class TestStrategyPattern
    {
        public static void Main(string[] args)
        {
            ITextFormatter formatter = new CapTextFormatter();
            ITextEditor editor = new TextEditor(formatter);
            editor.PublishText("Testing text in caps formatter");

            formatter = new LowerTextFormatter();
            editor = new TextEditor(formatter);
            editor.PublishText("Testing text in lower formatter");
        }
    }
}