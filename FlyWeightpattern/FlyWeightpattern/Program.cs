// See https://aka.ms/new-console-template for more information
using FlyWeightpattern;

Console.WriteLine("Hello, World!");


FlyWeightFactory flyWeightFactory= new ( new Car{Owner="me", Color="red", Company="BMW", Model="X5", Number="12345"}
,new Car{Owner="yyy", Color="red", Company="BMWs", Model="Xs5", Number="129345"}
);

flyWeightFactory.PrintFlyweight();
flyWeightFactory.GetFlyweight(new Car{Owner="me", Color="red", Company="BMW", Model="X5", Number="12345"});

flyWeightFactory.PrintFlyweight();

flyWeightFactory.GetFlyweight(new Car{Owner="mrre", Color="red", Company="BMW", Model="X5", Number="12345"});

flyWeightFactory.PrintFlyweight();