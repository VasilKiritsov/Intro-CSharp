using System;


namespace NumbersInRangeOneAndHundret
{
    public class NumbersInRangeOneAndHundret
    {
        public static void Main()
        {
            // get number from input between 1 and 100
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", number);
        }
    }
}
