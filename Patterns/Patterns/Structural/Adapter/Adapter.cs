namespace Patterns.Structural.Adapter
{
    public class Adapter : Sensor
    {
        private readonly FahrenheitSensor _fahrenheitSensor = new FahrenheitSensor();
        
        /// <summary>
        /// Return the temperature value in Celsius from sensor
        /// </summary>
        /// <returns></returns>
        public override float GetTemperature()
        {
            return _fahrenheitSensor.GetFahrenheitTemp();
        }
    }
}