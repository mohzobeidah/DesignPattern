using System.Xml.Serialization;

namespace adaptorPattern;

public class Employee
{

    [XmlAttribute]
    public int Id { get; set; }
    [XmlAttribute]
    public string Name { get; set; }

    public Employee()
    {
        
    }
    public Employee(string name , int id)
    {
        this.Id = id;
        this.Name = name; 
    }
}