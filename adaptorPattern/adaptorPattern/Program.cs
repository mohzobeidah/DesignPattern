// See https://aka.ms/new-console-template for more information

using adaptorPattern;

Console.WriteLine("Hello, World!");


  EmployeesManger.IEmpolyee emps = new EmployeesManger();
  
  
  Console.WriteLine(emps.GetAllEmployees());
Console.WriteLine("--------------------------------");

EmployeesManger.IEmpolyee empss = new EmployeeMangerAdaptor();
  
  
Console.WriteLine(empss.GetAllEmployees());

