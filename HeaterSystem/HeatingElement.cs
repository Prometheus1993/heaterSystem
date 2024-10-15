namespace HeaterSystem;

public class HeatingElement : IHeatingElement
{
    void IHeatingElement.Enable()
    {
        Console.WriteLine("Heating Element Enabled");
    }
    
    void IHeatingElement.Disable()
    {
        Console.WriteLine("Heating Element Disabled");
    }
}