namespace BuilderPattern.Builder
{
    public interface IRobotPlan
    {
         void SetRobotHead(string head);
         void SetRobotArms(string arms );
        void SetRobotBody(string Body);
        void SetRobotLegs(string Legs);


    }
}