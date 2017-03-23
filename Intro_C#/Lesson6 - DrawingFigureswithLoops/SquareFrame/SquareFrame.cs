using System;


namespace SquareFrame
{
    public class SquareFrame
    {
        static void Main()
        {
            // get number from input and draw a square frame 

            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                if (i ==  1 || i == number)
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("| ");
                }
                for (int j = 0; j < number - 2; j++)
                {
                    Console.Write("- ", number - 2);
                }
                if (i == 1 || i == number)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("|");
                }
                Console.WriteLine();
                
            }
        }
    }
}
