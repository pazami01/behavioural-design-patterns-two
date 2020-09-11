using System;

namespace state
{
    public class Robot : IRoboticState
    {

        private IRoboticState RoboticState { get; set; }

        public Robot() => RoboticState = new OnState(this);

        public void Walk() => RoboticState.Walk();

        public void Cook() => RoboticState.Cook();

        public void Off() => RoboticState.Off();

        public void On() => RoboticState.On();

        private class OnState : IRoboticState
        {
            private Robot _robot;

            public OnState(Robot robot) => _robot = robot;

            public void Cook()
            {
                Console.WriteLine("Cooking...");
                _robot.RoboticState = new CookState(_robot);
            }

            public void Off()
            {
                Console.WriteLine("Robot is switched off");
                _robot.RoboticState = new OffState(_robot);
            }

            public void On()
            {
                Console.WriteLine("Robot is already switched on");
            }

            public void Walk()
            {
                Console.WriteLine("Walking...");
                _robot.RoboticState = new WalkState(_robot);
            }
        }

        private class OffState : IRoboticState
        {
            private Robot _robot;

            public OffState(Robot robot) => _robot = robot;

            public void Cook()
            {
                Console.WriteLine($"Cannot cook at Off state.");
            }

            public void Off()
            {
                Console.WriteLine("Robot is already switched off");
            }

            public void On()
            {
                Console.WriteLine("Robot is switched on");
                _robot.RoboticState = new OnState(_robot);
            }

            public void Walk()
            {
                On();

                Console.WriteLine("Walking...");
                _robot.RoboticState = new WalkState(_robot);
            }
        }

        private class CookState : IRoboticState
        {
            private Robot _robot;

            public CookState(Robot robot) => _robot = robot;

            public void Cook()
            {
                Console.WriteLine("Robot is already cooking");
            }

            public void Off()
            {
                Console.WriteLine($"Cannot Off at Cook state.");
            }

            public void On()
            {
                Console.WriteLine("Robot is switched on");
                _robot.RoboticState = new OnState(_robot);
            }

            public void Walk()
            {
                Console.WriteLine("Walking...");
                _robot.RoboticState = new WalkState(_robot);
            }
        }

        private class WalkState : IRoboticState
        {
            private Robot _robot;

            public WalkState(Robot robot) => _robot = robot;

            public void Cook()
            {
                Console.WriteLine("Cooking...");
                _robot.RoboticState = new CookState(_robot);
            }

            public void Off()
            {
                Console.WriteLine("Robot is switched off");
                _robot.RoboticState = new OffState(_robot);
            }

            public void On()
            {
                Console.WriteLine("Robot is switched on");
                _robot.RoboticState = new OnState(_robot);
            }

            public void Walk()
            {
                Console.WriteLine("Robot is already walking");
            }
        }
    }
}