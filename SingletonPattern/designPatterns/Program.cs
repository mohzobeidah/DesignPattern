// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var res = SingletonGenerator.GetInstance;
Console.WriteLine(res);

var res1 = SingletonGenerator.GetInstance;
Console.WriteLine(res1);


var res2 = SingletonGenerator.GetInstance;
Console.WriteLine(res2);



Parallel.Invoke( 
    ()=>
Console.WriteLine(SingletonGenerator.GetInstance)

,
    ()=>Console.WriteLine(SingletonGenerator.GetInstance)
);





