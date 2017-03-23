using System;


namespace RechtangleOfNStars
{
    public class RechtangleOfNStars
    {
        static void Main()
        {
            // get number from input and draw a rectangle

            int number = int.Parse(Console.ReadLine());

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
