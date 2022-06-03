using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace prototypeDesignPattern;

public abstract class CloneableObject<T> where T:class
{
    public T ShallowCopy<T>()
    {

        return (T)this.MemberwiseClone() ;
    }

    public T DeepCopy<T>()
    {

        var result = JsonConvert.SerializeObject(this);
        return  JsonConvert.DeserializeObject<T>(result);;
    }

}