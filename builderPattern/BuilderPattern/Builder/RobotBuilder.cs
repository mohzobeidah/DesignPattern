namespace BuilderPattern.Builder
{
    public class RobotBuilder
    {
        private readonly IBuilder buildRobotOld;

        public RobotBuilder(IBuilder  buildRobotOld)
        {
            this.buildRobotOld = buildRobotOld;
        }


        public Robot getRobot()
        {

            return buildRobotOld.GetRobot();
        }
        public void MakeRobot()
        {
            this.buildRobotOld.BuildRobotArms();
               this.buildRobotOld.BuildRobotHead();
                  this.buildRobotOld.BuildRobotBody();
                     this.buildRobotOld.BuildRobotLegs();
        }
        
    }
}