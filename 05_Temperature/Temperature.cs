using System;

namespace _05_Temperature
{
    public enum Unit
    {
        Celcius,
        Fahrenheit
    } ;
    internal class Temperature
    {
        public Temperature(Unit unit, double input)
        {
            Fahrenheit = input;
            Celcius = input;
        }

        public Temperature()
        {
        }
        private double fahrenheit;
        private double celcius;
        public double Fahrenheit
        { get { return fahrenheit; }
          set { fahrenheit = value; } }
   
        public double Celcius
        { get { return celcius; }
          set { celcius = value; } }


        internal static double FahrenheitToCelcius(double v)
        {
            return (v - 32) * 5 / 9;
        }

        internal static double CelciusToFahrenheit(double v)
        {
            return v * 9 / 5 + 32;
        }
    }
}