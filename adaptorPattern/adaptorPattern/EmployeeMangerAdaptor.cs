using System.Text.Json.Serialization;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace adaptorPattern;

public class EmployeeMangerAdaptor:EmployeesManger,EmployeesManger.IEmpolyee
{
    public override string GetAllEmployees()
    {
      
        string xmlReader = base.GetAllEmployees();
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlReader);
        return JsonConvert.SerializeObject(doc , Formatting.Indented);
    }
}