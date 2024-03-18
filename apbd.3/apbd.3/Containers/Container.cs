using apbd._3.Interfaces;

namespace apbd._3.Containers;

public class Container : IContainer
{
    public double CargoMass { get; set; }
    public double TareWeight { get; set; }
    public double MaxPayload { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public string SerialNum { get; set; }
    
    //constructor - ctor or alt+insert
    //protected so you can use it in child classes
    protected Container()
    {
    }

    public virtual void Load(double cargoMass)
    {
        CargoMass = cargoMass;
        if (cargoMass > MaxPayload)
        {
            cargoMass = MaxPayload;
            throw new OverflowException();
        }
    }
    public virtual void Unload()
    {
        CargoMass = 0;
    }

    public virtual void getInfo()
    {
        Console.WriteLine("Serial Num: " + SerialNum + "\nCargo Mass: " + CargoMass + "\nMax Payload: " + MaxPayload);
    }
}



