using System;


namespace TriangleOfDollars
{
    public class TriangleOfDollars
    {
        static void Main()
        {
            // get number from input and draw triangle of dollars char

            int number = int.Parse(Console.ReadLine());

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
