using System;


namespace SequenceNumberNumberPlusOne
{
    public class SequenceNumberNumberPlusOne
    {
        public static void Main()
        {
            // get number from input and get a new equence number * 2 + 1;
            int number = int.Parse(Console.ReadLine());
            int equenceNum = 1;

            while (equenceNum <= number)
            {
                Console.WriteLine(equenceNum);
                equenceNum = equenceNum * 2 + 1;
            }
        }
    }
}
