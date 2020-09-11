namespace strategy
{
    public class LowerTextFormatter : ITextFormatter
    {
        public void Format(string text)
        {
            System.Console.WriteLine($"LowerTextFormatter: {text.ToLower()}");
        }
    }
}