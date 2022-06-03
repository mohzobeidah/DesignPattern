namespace BuilderPattern.Builder
{
    public class Robot : IRobotPlan
    {

        private  string robotBody;
        private  string robotArms;
        private  string robotHead;
        private  string robotLegs;
        public void SetRobotArms(string arms)
        {
           robotArms= arms;
        }

        public void SetRobotBody(string Body)
        {
          robotBody=Body;
        }

        public void SetRobotHead(string head)
        {
         robotHead =head;
        }

        public void SetRobotLegs(string Legs)
        {
          robotLegs= Legs;
        }
          public string getRobotArms( )
        {
          return robotArms;
        }

        public string getRobotBody( )
        {
          return robotBody;
        }

        public string getRobotHead( )
        {
         return robotHead ;
        }

        public string getRobotLegs( )
        {
        return  robotLegs ;
        }
    }
}