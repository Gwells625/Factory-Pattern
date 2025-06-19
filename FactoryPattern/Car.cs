namespace FactoryPattern;

public class Car : IVehicle
{
    public void Build()
    {
        Console.WriteLine("The Car is driving.");
    }
}