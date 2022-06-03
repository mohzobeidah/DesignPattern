namespace BuilderPattern.Builder
{
    public interface IBuilder
    {
        void BuildRobotHead();
         void BuildRobotArms();
        void BuildRobotBody();
        void BuildRobotLegs();
        
      
       Robot GetRobot();
    }
}