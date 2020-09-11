namespace state
{
    public interface IRoboticState
    {
        public void Walk();
        public void Cook();
        public void Off();
        public void On();
    }
}