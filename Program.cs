using ConsoleApp20;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new Car("Hyundai", "Elentra", 240, 2021);
        Car car2= new Car("Mercedes", "Sedan", 255, 2021);
        Bus bus1 = new Bus(30, 2018);
        Bus bus2 = new Bus(50, 2002);
        Vehicle[] vehicles = new Vehicle[] { car1, car2, bus1, bus2 };

        //foreach (var item in vehicles)
        //{
        //    Console.WriteLine(item.ShowInfo());
        //}
        Console.WriteLine(car1>car2);
    }
}