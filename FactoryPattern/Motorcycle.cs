namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void Build()
    {
        Console.WriteLine("The Motorcycle is revving.");
    }
}