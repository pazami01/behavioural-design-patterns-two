namespace observer
{
    public interface IObserver
    {
        public void Update(string desc);
        public void Subscribe();
        public void UnSubscribe();
    }
}