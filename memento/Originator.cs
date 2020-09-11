using System;
using System.ComponentModel.DataAnnotations;

namespace worksheet_nine_behavioural_design_patterns
{
    public class Originator
    {
        private CareTaker _careTaker;
        private string _lastUndoSavepoint;
        private const string _initialSavePointName = "INITIAL";
        public double X { get; set; }
        public double Y { get; set; }

        public Originator(double x, double y, CareTaker careTaker)
        {
            X = x;
            Y = y;
            _careTaker = careTaker;
            CreateSavePoint(_initialSavePointName);
        }

        public void CreateSavePoint(string savepointName)
        {
            Console.WriteLine($"Saving state...{savepointName}");
            Memento memento = new Memento(X, Y);
            _careTaker.SaveMemento(memento, savepointName);
            _lastUndoSavepoint = savepointName;
        }

        public void Undo()
        {
            OriginatorState(_lastUndoSavepoint);
        }

        public void Undo(string savepointName)
        {
            OriginatorState(savepointName);
        }

        public void UndoAll()
        {
            OriginatorState(_initialSavePointName);
            Console.WriteLine("Clearing all save points...");
            _careTaker.ClearSavePoints();
        }

        private void OriginatorState(string savepointName)
        {
            Console.WriteLine($"Undo at ...{savepointName}");
            Memento previousState = _careTaker.Memento(savepointName);
            X = previousState.X;
            Y = previousState.Y;
        }

        public override string ToString() => $"X: {X}, Y: {Y}";

        public void CreateSavepoint(string save1)
        {
            CreateSavePoint(save1);
        }
    }
}