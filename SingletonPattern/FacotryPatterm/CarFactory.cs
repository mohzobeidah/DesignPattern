
public class CarFactory
{
  
public static Car GetCar(string l) 
{
    return   l switch 
    {
        "S" =>   new SedunCar(),
        "T" =>   new SedunCar(),
       
    };
}
   


}



