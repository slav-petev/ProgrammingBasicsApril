using System;

namespace _08.TriangleArea
{
    class TriangleAreaExercise
    {
        static void Main(string[] args)
        {
            double firstCathetus = double.Parse(
                    Console.ReadLine());
            double secondCathetus = double.Parse(
                    Console.ReadLine());

            double area = firstCathetus * secondCathetus / 2;

            Console.WriteLine("{0:F2}", area);
        }
    }
}
