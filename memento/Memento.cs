namespace worksheet_nine_behavioural_design_patterns
{
    public class Memento
    {
        public double Y { get; }
        public double X { get; }

        public Memento(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}