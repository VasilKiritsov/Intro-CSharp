using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfFigures
{
    class areaOfFigures
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = squareSide * squareSide;
                Console.WriteLine("{0:f3}", squareArea);
            }
            if (word == "rectangle")
            {
                double firstRectangleSide = double.Parse(Console.ReadLine());
                double secondRectangleSide = double.Parse(Console.ReadLine());
                double rectangleArea = firstRectangleSide * secondRectangleSide;
                Console.WriteLine("{0:f3}", rectangleArea);
            }
            if (word == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * circleRadius * circleRadius;
                Console.WriteLine("{0:f3}", circleArea);
            }
            if (word == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                double triangleArea = triangleSide * triangleHeight / 2;
                Console.WriteLine("{0:f3}", triangleArea);
            }
        }
    }
}
