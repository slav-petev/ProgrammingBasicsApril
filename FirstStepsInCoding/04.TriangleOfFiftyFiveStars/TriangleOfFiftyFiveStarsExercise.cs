using System;

namespace _04.TriangleOfFiftyFiveStars
{
    class TriangleOfFiftyFiveStarsExercise
    {
        static void Main(string[] args)
        {
            /* We must print 10 rows of stars. The first will
             have 1 star, th second 2,..., and the tenth - 10
             When we sum the numbers 1 to 10, we get 55*/
            for (var i = 1;
                i <= 10;
                i++)
            {
                Console.WriteLine(
                    new string('*', i));
            }
        }
    }
}
