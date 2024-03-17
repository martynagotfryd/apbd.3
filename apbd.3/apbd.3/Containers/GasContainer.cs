using apbd._3.Interfaces;

namespace apbd._3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    private double Pressure { get; set; }
    
    protected GasContainer(double pressure) 
    {
        Pressure = pressure;
        TareWeight = 1000;
        Height = 400;
        Depth = 300;
        MaxPayload = 3000;
        SerialNum = "KON-G-{1++}";
    }

    public override void Unload()
    {
        CargoMass = CargoMass * 0.05;
    }
    
    public void NotifyHazard(string message)
    {
        throw new NotImplementedException();
    }
}