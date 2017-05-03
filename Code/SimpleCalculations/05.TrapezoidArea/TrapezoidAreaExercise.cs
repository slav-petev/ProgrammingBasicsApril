using System;

namespace _05.TrapezoidArea
{
    class TrapezoidAreaExercise
    {
        static void Main(string[] args)
        {
            double lowerBase = double.Parse(
                Console.ReadLine());
            double upperBase = double.Parse(
                    Console.ReadLine());
            double height = double.Parse(
                    Console.ReadLine());

            double area = (upperBase + lowerBase) *
                    height / 2;

            Console.WriteLine(area);
        }
    }
}
