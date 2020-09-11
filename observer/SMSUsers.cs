using System;

namespace observer
{
    public class SMSUsers : IObserver
    {
        private ISubject _subject;
        private string _user;

        public SMSUsers(ISubject subject, string s)
        {
            _subject = subject;
            _user = s;
        }

        public void Update(string desc) => Console.WriteLine($"[{_user}]: {desc}");

        public void Subscribe()
        {
            Console.WriteLine($"Subscribing {_user} to {_subject.SubjectDetails()} ...");
            _subject.SubscribeObserver(this);
            Console.WriteLine("Subscribed successfully");
        }

        public void UnSubscribe()
        {
            Console.WriteLine($"Unsubscribing {_user} to {_subject.SubjectDetails()} ...");
            _subject.UnSubscribeObserver(this);
            Console.WriteLine("Unsubscribed successfully");
        }
    }
}