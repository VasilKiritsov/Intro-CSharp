using System;


namespace RombusOfStars
{
    public class RombusOfStars
    {
        static void Main()
        {
            // get number from input and draw rombus with '*'
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                for (int j = 1; j <= number - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = number; i > 0 ; i--)
            {
                for (int j = 1; j <= number - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
