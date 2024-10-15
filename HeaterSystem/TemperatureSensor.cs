namespace HeaterSystem;

public class TemperatureSensor : ITemperatureSensor
{
    public double GetTemperature()
    {
        return 20.0;
    }
}