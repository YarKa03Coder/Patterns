namespace Patterns.Structural.Adapter
{
    public class FahrenheitSensor
    {
        public float GetFahrenheitTemp()
        {
            // A range of 0... +100 ° F(Fahrenheit) corresponds roughly to a range of -17.8... +37.8 ° C in Celsius.
            return (float) (new System.Random().NextDouble() * (100 - 0) + 0);
        }
    }
}