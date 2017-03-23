using System;


namespace FibonacciNumbers
{
    public class FibonacciNumbers
    {
        public static void Main()
        {
            // get number from input and get Fibonacci numbers
            int number = int.Parse(Console.ReadLine());

            int firstNumber = 1;
            int secondNumber = 1;

            for (int i = 0; i < number - 1; i++)
            {
                int tempNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = tempNumber;
            }

            Console.WriteLine(secondNumber);
        }
    }
}
