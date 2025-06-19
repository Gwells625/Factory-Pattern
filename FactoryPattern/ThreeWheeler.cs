namespace FactoryPattern;

public class ThreeWheeler : IVehicle
{
    public void Build()
    {
        Console.WriteLine("The ThreeWheeler is drifting.");
    }
}