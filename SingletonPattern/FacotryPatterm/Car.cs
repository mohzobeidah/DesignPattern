public abstract class Car 
{
    public string Name { get; set; }
  
    public int Model { get; set; }


    public void RunCar(){
        Console.WriteLine(this.Name +" is Running");
    }
    
    public void ShowCar(){
        Console.WriteLine(this.Model +" is ModelNumber");
    }
}