using System;
using System.Collections.Generic;
using observer;

namespace observer
{
    public static class TestObserver
    {
        public static void Main(string[] args)
        {
            ISubject subject = new CommentaryObject(new List<IObserver>(), "Football Match [2019MAR24]");
            IObserver observer = new SMSUsers(subject, "Adam Warner [Manchester]");
            observer.Subscribe();

            Console.WriteLine();

            IObserver observer2 = new SMSUsers(subject, "Tim Ronney [London]");
            observer2.Subscribe();

            ICommentary cObject = subject as ICommentary;
            cObject.Description = "Welcome to live football match";
            cObject.Description = "Current score 0-0";


            Console.WriteLine();

            observer2.UnSubscribe();

            Console.WriteLine();

            cObject.Description = "It's a goal!!";
            cObject.Description = "Current score 1-0";

            Console.WriteLine();

            IObserver observer3 = new SMSUsers(subject, "Marrie [Paris]");
            observer3.Subscribe();

            Console.WriteLine();

            cObject.Description = "It's another goal!!";
            cObject.Description = "Half-time score 2-0";
        }
    }
}