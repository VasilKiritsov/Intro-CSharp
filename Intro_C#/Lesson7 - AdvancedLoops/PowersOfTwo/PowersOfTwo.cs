using System;


namespace PowersOfTwo
{
    public class PowersOfTwo
    {
        public static void Main()
        {
            // get number from input and write 2 powered on number

            int number = int.Parse(Console.ReadLine());
            int poweredNumber = 1;
            Console.WriteLine(1);
            for (int i = 0; i < number; i++)
            {
                poweredNumber *= 2;
                Console.WriteLine(poweredNumber);
            }
        }
    }
}
