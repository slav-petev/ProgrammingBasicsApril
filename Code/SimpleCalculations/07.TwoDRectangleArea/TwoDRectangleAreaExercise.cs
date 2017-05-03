using System;

namespace _07.TwoDRectangleArea
{
    class TwoDRectangleAreaExercise
    {
        static void Main(string[] args)
        {
            double lowerLeftPointXCoordinate = double.Parse(
               Console.ReadLine());
            double lowerLeftPointYCoordinate = double.Parse(
                    Console.ReadLine());
            double upperRightPointXCoordinate = double.Parse(
                    Console.ReadLine());
            double upperRightPointYCoordinate = double.Parse(
                    Console.ReadLine());

            double width = Math.Abs(lowerLeftPointXCoordinate -
                    upperRightPointXCoordinate);
            double height = Math.Abs(lowerLeftPointYCoordinate -
                    upperRightPointYCoordinate);
            double perimeter = 2 * (width + height);
            double area = width * height;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
