using System;


namespace GreatestCommonDivisor
{
    public class GreatestCommonDivisor
    {
        public static void Main()
        {
            // get two number from input and calculate greatest common divisor
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            while (secondNumber != 0)
            {
                int oldSecondNumber = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = oldSecondNumber;
            }

            Console.WriteLine(firstNumber);
        }
    }
}
