using apbd._3.Interfaces;

namespace apbd._3.Containers;

public class Container : IContainer
{
    public double CargoMass { get; set; }
    
    //constructor - ctor or alt+insert
    //protected so you can use it in child classes
    protected Container(double cargoMass)
    {
        CargoMass = cargoMass;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoMass)
    {
        throw new OverflowException();
    }
}



