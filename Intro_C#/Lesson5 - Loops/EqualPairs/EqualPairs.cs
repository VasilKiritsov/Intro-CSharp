using System;

namespace EqualPairs
{
    public class EqualPairs
    {
        public static void Main()
        {
            // get number from input and compare in pair 

            int n = int.Parse(Console.ReadLine()); // get how mutch numbers will be inputed

            int prevPair = 0;
            int maxDifference = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int currentPair = firstNum + secondNum;
                if (i > 0)
                {
                    int difference = Math.Abs(currentPair - prevPair);
                    if (difference > maxDifference)
                    {
                        maxDifference = difference;
                    }
                }
                prevPair = currentPair;
            }

            if (maxDifference == 0 || maxDifference == int.MinValue)
            {
                Console.WriteLine("Yes, value={0}", prevPair);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDifference);
            }
        }
    }
}
