using System;


namespace CheckPrimeNumbers
{
    public class CheckPrimeNumbers
    {
        public static void Main()
        {
            // get number from input and check if is prime or not
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (number < 2)
            {
                Console.WriteLine("Not prime");
            }
            else
            {

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime && number < 0)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
