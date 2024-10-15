namespace HeaterSystem;

public class Thermostat
{
    private readonly ITemperatureSensor _temperatureSensor;
    private readonly IHeatingElement _heatingElement;
    
    public double Setpoint { get; set; }

    public double Offset { get; set; }

    public Thermostat(ITemperatureSensor temperatureSensor, IHeatingElement heatingElement)
    {
        _heatingElement = heatingElement;
        _temperatureSensor = temperatureSensor;
    }

    public void Work()
    {
        var temperature = _temperatureSensor.GetTemperature();
        if (temperature < Setpoint - Offset)
        {
            _heatingElement.Enable();
        }
        else if (temperature > Setpoint + Offset)
        {
            _heatingElement.Disable();
        }
    }
}