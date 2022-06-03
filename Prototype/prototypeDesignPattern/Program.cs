// See https://aka.ms/new-console-template for more information

using prototypeDesignPattern;

Console.WriteLine("Hello, World!");


Person p1 = new ();
p1.Name = "John";
p1.Age = 30;
p1.idInfo= new (11111);

Person p2 = p1.ShallowCopy<Person>() ;
Person p3 = p1.DeepCopy<Person>() ;
Person p4 = p1;
Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());
Console.WriteLine(p3.ToString());
Console.WriteLine(p4.ToString());

p1.Name = "Reem";
p1.Age = 40;
p1.idInfo= new (22222);
Console.WriteLine("----------------------------------");
Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());
Console.WriteLine(p3.ToString());
Console.WriteLine(p4.ToString());


public class Person:CloneableObject<Person>
{

    public string Name { get; set; }
    public int Age { get; set; }

    public IdInfo idInfo { get; set; }

  public string ToString(){
      return $"{this.Name} is {this.Age} years old.  and  idinfo is {this.idInfo.Id}";
  }

   

    // public Person ShallowCopy()
    // {
    //
    //     return this.MemberwiseClone() as Person;
    // }
    //
    // public Person DeepCopy()
    // {
    //
    //     var person = this.MemberwiseClone() as Person;
    //     person.idInfo = new(this.idInfo.Id);
    //     person.Name = string.Copy(this.Name);
    //
    //     return person;
    // }

    public object Clone()
    {
       var person = this.MemberwiseClone() as Person;
        person.idInfo = new(this.idInfo.Id);
        person.Name = string.Copy(this.Name);

        return person;
    }
}

public class IdInfo
{
    public int Id { get; set; }
    public IdInfo(int id)
    {
        this.Id = id;
    }
}