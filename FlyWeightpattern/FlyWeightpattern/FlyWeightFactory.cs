namespace FlyWeightpattern
{

    
    
    public class FlyWeightFactory
    {
        private List<Tuple<Flyweight, string>> _flyWwightCar = new List<Tuple<Flyweight, string>>();    
    
      public FlyWeightFactory(params Car[] car)
      {
          foreach (var item in car)
          {
              _flyWwightCar.Add(new ( new Flyweight(item), getKey(item)));
          }

     
      }

        private string getKey(Car item)
        {
            var elments = new List<string>();
            elments.Add(item.Company);
            elments.Add(item.Model);
            elments.Add(item.Color);
            if(item.Owner!=null && item.Number!=null)
            {
                elments.Add(item.Owner);
                elments.Add(item.Number);
            }
            elments.Sort();
            return string.Join("_", elments);

        }
        
        public Flyweight GetFlyweight(Car car)
        {   
            var key = getKey(car);
            var flyweight = _flyWwightCar.FirstOrDefault(x => x.Item2 == key);
            if (flyweight == null)
            {
                flyweight = new Tuple<Flyweight, string>(new Flyweight(car), key);
                 Console.WriteLine(flyweight.Item2);
                _flyWwightCar.Add(flyweight);
            }
            return flyweight.Item1;
        }

        public void PrintFlyweight()
        {
            Console.WriteLine($" count ={_flyWwightCar.Count()}");
            
            foreach (var item in _flyWwightCar)
            {
                Console.WriteLine(item.Item2);
            }

                 Console.WriteLine(" ---------------------------------------");
        }
    }
    
}