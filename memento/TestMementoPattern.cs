using System;
using System.Threading.Channels;

namespace worksheet_nine_behavioural_design_patterns
{
    public static class TestMementoPattern
    {
        public static void Main(string[] args)
        {
            var careTaker = new CareTaker();
            var originator = new Originator(5, 10, careTaker);
            Console.WriteLine($"Default State: {originator}");

            originator.X = originator.Y * 51;
            Console.WriteLine($"State: {originator}");

            originator.CreateSavepoint("SAVE1");
            originator.Y = originator.X / 22;
            Console.WriteLine($"State: {originator}");

            originator.Undo();
            Console.WriteLine($"State after undo: {originator}");

            originator.X = Math.Pow(originator.X, 3);
            originator.CreateSavepoint("SAVE2");
            Console.WriteLine($"State: {originator}");

            originator.Y = originator.X - 30;
            originator.CreateSavepoint("SAVE3");
            Console.WriteLine($"State: {originator}");

            originator.Y = originator.X / 22;
            originator.CreateSavepoint("SAVE4");
            Console.WriteLine($"State: {originator}");

            originator.Undo("SAVE2");
            Console.WriteLine($"Retrieving at: {originator}");
            originator.UndoAll();
            Console.WriteLine($"State after undo all: {originator}");
        }
    }
}