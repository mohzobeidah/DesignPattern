using Newtonsoft.Json;

namespace FlyWeightpattern
{
    public class Flyweight
    {
        private Car _car;
        public Flyweight(Car car)   // constructor
        {
            this._car = car;
        }

        public void Operatiob(Car unqiueState){
            string s =JsonConvert.SerializeObject(this._car);
            string u =JsonConvert.SerializeObject(unqiueState);
            Console.WriteLine( "shared"+ s + " unqiue " + u);

        }
      
    }
      public class Car
    {
        public string Owner { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
         public string Company { get; set; }
    
    
        
    }
    
}