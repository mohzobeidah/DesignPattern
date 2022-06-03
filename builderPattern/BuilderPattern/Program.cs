// See https://aka.ms/new-console-template for more information
using BuilderPattern.Builder;

Console.WriteLine("Hello, World!");

BuilderPattern.Builder.IBuilder buildRobotOld =  new BuilderPattern.Builder.BuildRobotOld();
RobotBuilder robotBuilder = new RobotBuilder(buildRobotOld);
robotBuilder.MakeRobot();
var x =robotBuilder.getRobot();
Console.WriteLine(x.getRobotArms());


