namespace CompsitePattern
{
    public class Employee : IEmpolyee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public Employee(string name, string department, string role)
        {
            Name = name;
            Department = department;
            Role = role;
        }
        public void Getdatils()
        {
            Console.WriteLine($"Name: {Name} , Department: {Department} , Role: {Role}");
        }
    }
  
}