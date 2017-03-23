using System;


namespace NumbersNToOne
{
    public class NumbersNToOne
    {
        public static void Main()
        {
            // get number from input and write numbers between number and 1

            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
