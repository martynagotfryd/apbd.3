using apbd._3.Exceptions;
using apbd._3.Interfaces;

namespace apbd._3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private static int num = 0;
    private bool Hazard { get; set; }
    protected LiquidContainer(bool hazard) 
    {
        Hazard = hazard;
        TareWeight = 1000;
        Height = 400;
        Depth = 300;
        MaxPayload = 3000;
        num++;
        SerialNum = "KON-L-{num}";
    }

    public override void Load(double cargoMass)
    {
        double capacity = Hazard ? MaxPayload * 0.5 : MaxPayload * 0.9;
        if (cargoMass > capacity)
        {
            throw new OverFillException($"Cannot load {cargoMass} kg into container {SerialNum}.");
        }

        CargoMass = cargoMass;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Hazard in Liquid Container {SerialNum}: {message}");
    }
}