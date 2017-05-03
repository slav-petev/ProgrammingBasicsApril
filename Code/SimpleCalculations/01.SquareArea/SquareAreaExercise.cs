using System;

namespace _01.SquareArea
{
    class SquareAreaExercise
    {
        static void Main(string[] args)
        {
            int squareSide = int.Parse
               (Console.ReadLine());

            int squareArea =
                squareSide * squareSide;


            Console.WriteLine(squareArea);
        }
    }
}
