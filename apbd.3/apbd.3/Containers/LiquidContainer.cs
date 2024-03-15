namespace apbd._3.Containers;

public class LiquidContainer : Container
{
    protected LiquidContainer(double cargoMass) : base(cargoMass)
    {
    }

    public override void Load(double cargoMass)
    {
        base.Load(cargoMass);
    }
}