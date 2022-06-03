public  abstract class CloneablePrototype<T> where T : class{
  public T ShallowCopy<T>()
    {

        return this.MemberwiseClone() as T;
    }

    public Person DeepCopy()
    {

        var obj =  JsonConverter.SerializeObject<T>((this));
        return JsonConverter.DeserializeObject<T>(obj);;
    }
}
