namespace strategy
{
    public interface ITextEditor
    {
        ITextFormatter TextFormatter { get; set; }
        void PublishText(string text);
    }
}