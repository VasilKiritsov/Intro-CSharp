using System;


namespace NumbersToNStepThree
{
    public class NumbersToNStepThree
    {
        public static void Main()
        {
            // get number from input and write numbers between 1 and number, next number is equal to last plus 3 

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
