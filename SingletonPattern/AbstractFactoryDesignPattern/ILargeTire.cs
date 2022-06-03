namespace AbstractFactoryDesignPattern
{
    public interface ILargeTire:ITire
    {
        
    }
    public class LargeTire : ILargeTire
    {
        public void Draw()
        {
        Console.WriteLine("LargeTire");
        }
    }
}