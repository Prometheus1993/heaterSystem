namespace HeaterSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using object initializer to set properties
            Thermostat thermostat = new Thermostat(new TemperatureSensor(), new HeatingElement())
            {
                Setpoint = 20.0,
                Offset = 0.5
            };
            thermostat.Work();
        }
    }
}