// See https://aka.ms/new-console-template for more information
using CompsitePattern;

Console.WriteLine("Hello, World!");


IEmpolyee empolyee1 = new Employee("Empolyee1", "IT", "Empolyee");
IEmpolyee empolyee2 = new Employee("Empolyee2", "IT", "Empolyee");
IEmpolyee empolyee3 = new Employee("Empolyee3", "IT", "Empolyee");

IEmpolyee manager = new Manger("Manger", "IT", "Manager"){Employees= new List<IEmpolyee>{empolyee1,empolyee2,empolyee3}};

IEmpolyee empolyee4= new Employee("Empolyee4", "HR", "Empolyee");
IEmpolyee empolyee5 = new Employee("Empolyee5", "HR", "Empolyee");
IEmpolyee empolyee6 = new Employee("Empolyee6", "HR", "Empolyee");
IEmpolyee manager2 = new Manger("Manger2", "HR", "Manager"){Employees= new List<IEmpolyee>{empolyee4,empolyee5,empolyee6}};

IEmpolyee manager3 = new Manger("Manger2", "HR", "Manager"){Employees= new List<IEmpolyee>{manager,manager2}};
manager.Getdatils();
Console.WriteLine("-----------------------------------------------------");
manager2.Getdatils();
Console.WriteLine("-----------------------------------------------------");
manager3.Getdatils();