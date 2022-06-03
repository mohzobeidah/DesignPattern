namespace BuilderPattern.Builder
{
    public class BuildRobotOld : IBuilder
    {
        private readonly Robot _robot;

        public BuildRobotOld()
        {
            this._robot =  new Robot();
        }

     
        public void BuildRobotArms()
        {
          _robot.SetRobotArms("arms");
        }

        public void BuildRobotBody()
        {
             _robot.SetRobotArms("body");
        }

        public void BuildRobotHead()
        {
            _robot.SetRobotArms("head");
        }

        public void BuildRobotLegs()
        {
              _robot.SetRobotArms("leg");
        }

        public Robot GetRobot()
        {
            return _robot;
        }

       
    }
}