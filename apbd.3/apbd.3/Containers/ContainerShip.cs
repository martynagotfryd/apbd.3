using apbd._3.Exceptions;

namespace apbd._3.Containers;

public class ContainerShip
{
    public List<Container> Containers { set; get; }
    public double Speed { set; get; }
    public double MaxContainers { set; get; }
    public double MaxWeight { set; get; }
    public double Weight { set; get; }

    public ContainerShip()
    {
        Containers = new List<Container>();
        Weight = 0;
        Speed = 100;
        MaxContainers = 10;
        MaxWeight = 1000;
    }

    public void LoadContainer(Container container)
    {
        if (container.CargoMass + Weight < MaxWeight)
        {
            Containers.Add(container);
            Weight += container.CargoMass;
        }
        else
        {
            throw new OverFillException("OverFill");
        }
    }

    public void LoadContainters(List<Container> containers)
    {
        foreach (Container container in containers)
        {
            if (container.CargoMass + Weight < MaxWeight)
            {
                Containers.Add(container);
                Weight += container.CargoMass;
            }
            else
            {
                throw new OverFillException("OverFill");
            }
        }
    }

    public void RemoveContainerBySerialNum(string serialNum)
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].SerialNum.Equals(serialNum))
            {
                Containers.RemoveAt(i);
                break;
            }
        }
    }

    public void RemoveContainerByIndex(int index)
    {
        if (index >= 0 && index < Containers.Count)
        {
            Containers.RemoveAt(index);
        } 
    }

    public void Transfer(ContainerShip containerShip, string serialNum)
    {
        Container containerToTransfer = null;

        foreach (Container container in Containers)
        {
            if (container.SerialNum.Equals(serialNum))
            {
                containerToTransfer = container;
                break; 
            }
        }

        if (containerToTransfer != null)
        {
            Containers.Remove(containerToTransfer); 
            containerShip.Containers.Add(containerToTransfer); 
        }
    }

    public void GetInfo()
    {
        Console.WriteLine("Speed: " + Speed + "\nMaxContainers: " + MaxContainers + "\nMaxWeight: " + MaxWeight);
        
        var i = 1;
        if (Containers.Count <= 0) return;
        
        foreach (Container container in Containers)
        {
            Console.WriteLine("Container " + i + ": " + container.SerialNum);
            i++;
        }
    }
}