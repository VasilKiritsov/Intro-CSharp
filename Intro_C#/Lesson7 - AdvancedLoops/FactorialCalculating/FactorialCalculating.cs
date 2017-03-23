using System;


namespace FactorialCalculating
{
    public class FactorialCalculating
    {
        public static void Main()
        {
            // get number from input and calculate factorial of number
            long number = long.Parse(Console.ReadLine());
            long factorial = 1;

            do
            {
                factorial *= number;
                number--;
            } while (number > 1);

            Console.WriteLine(factorial);
        }
    }
}
