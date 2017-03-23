using System;


namespace NumbersPyramid
{
    public class NumbersPyramid
    {
        public static void Main()
        {
            // get number from input and draw a numbers pyramid
            int number = int.Parse(Console.ReadLine());
            int numberInside = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(numberInside + " ");
                    numberInside++;
                    if (numberInside > number)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (numberInside > number)
                {
                    break;
                }
            }
        }
    }
}
