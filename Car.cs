namespace ConsoleApp20;

public class Car:Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int MaxSpeed { get; set; }
    public Car(string brand, string model,int maxSpeed, int year):base(year)
    {
        MaxSpeed = maxSpeed;
        Brand = brand;
        Model = model;
    }
    public override string ShowInfo()
    {
        return $"{Brand} {Model} {MaxSpeed} {Year} {Color}";
    }
    public static bool operator >(Car car1, Car car2) => car1.MaxSpeed > car2.MaxSpeed;
    public static bool operator <(Car car1, Car car2) => car1.MaxSpeed < car2.MaxSpeed;

}
