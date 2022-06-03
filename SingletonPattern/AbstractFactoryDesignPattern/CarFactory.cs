
using AbstractFactoryDesignPattern;

public class CarFactory : IFactoryCar
{
    public  ITire DrawTire(string type)
    {
      return  type switch 
    {
        "S" =>   new LargeTire(),
        "L" =>   new SmallTire(),
    
    };
    }

    public Car GetCar(string type)
   {
        return  type switch 
        {
            "S" =>   new LargeCar(),
            "L" =>   new SmallCar(),
        
        };
    }
}
