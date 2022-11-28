using System.Reflection;

namespace ConsoleApp20;

internal class Bus:Vehicle
{
    public int PassengerCount { get; set; }
    public Bus(int passengerCount, int year):base(year)
    {
        PassengerCount = passengerCount;
    }

    public override string ShowInfo()
    {
        return $" {Year} {Color} {PassengerCount}";
    }
}
