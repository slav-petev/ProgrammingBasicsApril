using System;

namespace _11.USDToBGN
{
    class USDToBGNExercise
    {
        static void Main(string[] args)
        {
            double usdAmount = double.Parse(
                    Console.ReadLine());

            double bgnAmount = usdAmount * 1.79549;

            Console.WriteLine("{0:F2} BGN", bgnAmount);
        }
    }
}
