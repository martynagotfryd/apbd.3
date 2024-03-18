// See https://aka.ms/new-console-template for more information

using apbd._3;
using apbd._3.Containers;

Container liquidContainer = new LiquidContainer(true);
Container liquidContainer2 = new LiquidContainer(true);
Container gasContainer = new GasContainer(22.2);
Container refrigeratedContainer = new RefrigeratedContainer("fruits", 13.0);
// Container refrigeratedContainer2 = new RefrigeratedContainer("fruits", 14.0);

List<Container> containers = new();
containers.Add(liquidContainer2);
containers.Add(gasContainer);
containers.Add(refrigeratedContainer);

// liquidContainer.getInfo();
// liquidContainer.Load(2000);
// liquidContainer2.getInfo();

// gasContainer.Load(100.0);
// gasContainer.getInfo();
// gasContainer.Unload();
// gasContainer.getInfo();

ContainerShip containerShip = new ContainerShip();
ContainerShip containerShip2 = new ContainerShip();

// liquidContainer.Load(1200.0);

containerShip.LoadContainer(liquidContainer);
containerShip.LoadContainters(containers);
containerShip.GetInfo();

containerShip.RemoveContainerBySerialNum("KON-R-1");
containerShip.GetInfo();

containerShip.RemoveContainerByIndex(1);
containerShip.GetInfo();

containerShip.Transfer(containerShip2, "KON-G-1");
containerShip.GetInfo();
containerShip2.GetInfo();


