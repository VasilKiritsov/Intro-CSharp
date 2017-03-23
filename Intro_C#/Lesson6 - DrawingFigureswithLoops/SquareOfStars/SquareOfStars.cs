using System;


namespace SquareOfStars
{
    public class SquareOfStars
    {
        static void Main()
        {
            // get number from input and draw square
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
