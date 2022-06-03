namespace AbstractFactoryDesignPattern
{
    public interface IFactoryCar
    {
         ITire DrawTire(string type);
          Car GetCar(string type);
    }
}