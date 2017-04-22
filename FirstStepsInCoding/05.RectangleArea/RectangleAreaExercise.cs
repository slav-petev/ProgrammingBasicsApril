using System;

namespace _05.RectangleArea
{
    class RectangleAreaExercise
    {
        static void Main(string[] args)
        {
            var firstSide = double
                .Parse(Console.ReadLine());
            var secondSide = double
                .Parse(Console.ReadLine());

            var area = firstSide *
                secondSide;

            Console.WriteLine(area);
        }
    }
}
