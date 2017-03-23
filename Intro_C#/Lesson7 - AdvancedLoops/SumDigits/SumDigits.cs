using System;


namespace SumDigits
{
    public class SumDigits
    {
        public static void Main()
        {
            // get number from input and sum the digits
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            do
            {
                sumOfDigits += (number % 10);
                number /= 10;
            } while (number > 0);

            Console.WriteLine(sumOfDigits);
        }
    }
}
