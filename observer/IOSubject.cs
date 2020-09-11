namespace observer
{
    public interface ISubject
    {
        public void SubscribeObserver(IObserver observer);
        public void UnSubscribeObserver(IObserver observer);
        public void NotifyObservers();
        public string SubjectDetails();
    }
}