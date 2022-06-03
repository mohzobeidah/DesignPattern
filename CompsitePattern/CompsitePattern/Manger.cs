namespace CompsitePattern
{
    public class Manger:IEmpolyee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public List<IEmpolyee> Employees { get; set; }
        public Manger(string name, string department, string role)
        {
            Name = name;
            Department = department;
            Role = role;
            Employees = new List<IEmpolyee>();
        }
        public void Getdatils()
        {
            Console.WriteLine($"Name: {Name} , Department: {Department} , Role: {Role}");
            foreach (var item in Employees)
            {
                item.Getdatils();
            }
        }
    }
   
}