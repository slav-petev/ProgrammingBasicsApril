using System;

namespace _09.CelsiusToFarenheit
{
    class CelsiusToFarenheitExercise
    {
        static void Main(string[] args)
        {
            double celsiusTemperature = double.Parse(
                    Console.ReadLine());

            double farenheitTemperature = celsiusTemperature * 1.8 +
                    32;

            Console.WriteLine("{0:F2}", farenheitTemperature);
        }
    }
}
