using System;

namespace _06.SquareOfStars
{
    class SquareOfStarsExercise
    {
        static void Main(string[] args)
        {
            var squareSize = int.Parse(
                Console.ReadLine());

            /*The first and last row contain only stars.
             Se we can create a string consisting only of
             stars*/

            var fullRow = new string('*',
                squareSize);
            Console.WriteLine(fullRow);

            var squareBodyHeight = 
                squareSize - 2;
            for (var i = 0;
                i < squareBodyHeight;
                i++)
            {
                Console.WriteLine("*{0}*",
                    new string(' ', 
                    squareSize - 2));
            }

            Console.WriteLine(fullRow);
        }
    }
}
