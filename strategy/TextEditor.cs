namespace strategy
{
    public class TextEditor : ITextEditor
    {
        public ITextFormatter TextFormatter { get; set; }

        public TextEditor(ITextFormatter textFormatter)
        {
            TextFormatter = textFormatter;
        }

        public void PublishText(string text)
        {
            TextFormatter.Format(text);
        }
    }
}