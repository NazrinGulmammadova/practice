using ConsoleApp19.Interfaces;

namespace ConsoleApp19.Classes;

public class Employee : IPerson
{
    public int Id { get; }
    public string Salary { get; set; }
    public string Name { get; set; }
    public int Age { get; set; } 
    public Employee(int id)
    {
        Id = id;
        id++;
    }

    public string ShowInfo()
    {
        return $"{Name} {Age} {Id} {Salary}";
    }
    public override string ToString()
    { 
        return ShowInfo();
    }
}
