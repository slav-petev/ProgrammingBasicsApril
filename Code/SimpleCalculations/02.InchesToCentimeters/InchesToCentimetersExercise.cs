using System;

namespace _02.InchesToCentimeters
{
    class InchesToCentimetersExercise
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(
                Console.ReadLine());

            double centimetersInInch = 2.54;

            double centimeters = inches * centimetersInInch;

            Console.WriteLine("{0:F2}", centimeters);
        }
    }
}
