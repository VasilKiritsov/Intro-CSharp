using System;


namespace NumberTable
{
    public class NumberTable
    {
        private static int i;

        public static void Main()
        {
            //get number and draw a table from number
            int number = int.Parse(Console.ReadLine());

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    int numberInside = row + col + 1;
                    if (numberInside > number)
                    {
                        numberInside = 2 * number - numberInside;
                    }
                    Console.Write(numberInside + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
