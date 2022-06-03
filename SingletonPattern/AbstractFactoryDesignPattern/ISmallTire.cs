namespace AbstractFactoryDesignPattern
{
    public interface ISmallTire:ITire
    {
      
    }
     public class SmallTire:ISmallTire
    {
         public void Draw()
        {
        Console.WriteLine("SmallTire");
        }
    }
}
