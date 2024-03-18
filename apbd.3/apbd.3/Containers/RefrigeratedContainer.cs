namespace apbd._3.Containers;

public class RefrigeratedContainer : Container
{
    private static int num = 0;
    private string Type { get; set; }
    private double Temperature { get; set; }
    private Dictionary<string, double> _dictionary= new();
    
    public RefrigeratedContainer(string type, double temperature) 
    {
        _dictionary.Add("fruits", 13.3);
        _dictionary.Add("meat", 2.0);
        _dictionary.Add("eggs", 19.0);
        
        if (_dictionary.ContainsKey(type) && _dictionary[type] >= temperature)
        {
            Type = type;
            Temperature = temperature;
        }
        else 
        {
            throw new Exception("Temperature is too low for given type or type doesnt exist.");
        }
        
        TareWeight = 1000;
        Height = 400;
        Depth = 300;
        MaxPayload = 3000;
        num++;
        SerialNum = "KON-R-" + num;
    }
}