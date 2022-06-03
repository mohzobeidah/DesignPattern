using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace adaptorPattern;

public class EmployeesManger:EmployeesManger.IEmpolyee
{

    private List<Employee> employees= new();
    public EmployeesManger()
    {

        
        
        employees.Add(new ("mohammed", 1));
        employees.Add(new ("khalid", 2));
        employees.Add(new ("kareem", 3));
        
        
    }

    public virtual string GetAllEmployees()
    {
        var emptyNameSpace = new XmlSerializerNamespaces(new[] {XmlQualifiedName.Empty});
        var serlizer = new XmlSerializer(employees.GetType());

        var setting = new XmlWriterSettings();
        setting.Indent = true;
        setting.OmitXmlDeclaration = true;
        using (var stream = new StringWriter())
        {
            using (var writer = XmlWriter.Create(stream, setting))
            {
                serlizer.Serialize(writer, employees, emptyNameSpace);

                return stream.ToString();
            }
        }

    }
    
    public interface IEmpolyee
    {
        string GetAllEmployees();
    }
}