using System;

namespace state
{
    public static class TestStatePattern
    {
        public static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.Walk();
            robot.Cook();
            robot.Walk();
            robot.Off();
            robot.On();

            robot.Walk();
            robot.Off();
            robot.Cook();
        }
    }
}