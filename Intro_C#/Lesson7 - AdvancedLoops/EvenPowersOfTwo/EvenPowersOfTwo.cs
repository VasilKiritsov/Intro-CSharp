using System;


namespace EvenPowersOfTwo
{
    public class EvenPowersOfTwo
    {
        public static void Main()
        {
            // get number from input and get even powered degree
            int number = int.Parse(Console.ReadLine());
            int poweredNumber = 1;
            Console.WriteLine(poweredNumber);
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    poweredNumber *= 4;
                    Console.WriteLine(poweredNumber);
                }
            }
        }
    }
}
