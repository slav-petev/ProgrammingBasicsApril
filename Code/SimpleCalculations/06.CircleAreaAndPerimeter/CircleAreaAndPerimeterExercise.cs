using System;

namespace _06.CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeterExercise
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(
                    Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimeter = {0}", perimeter);
        }
    }
}
