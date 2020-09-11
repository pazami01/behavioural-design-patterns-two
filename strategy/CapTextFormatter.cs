namespace strategy
{
    public class CapTextFormatter : ITextFormatter
    {
        public void Format(string text)
        {
            System.Console.WriteLine($"CapTextFormatter: {text.ToUpper()}");
        }
    }
}