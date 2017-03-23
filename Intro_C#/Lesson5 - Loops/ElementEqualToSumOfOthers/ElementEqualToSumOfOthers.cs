using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementEqualToSumOfOthers
{
    class ElementEqualToSumOfOthers
    {
        static void Main(string[] args)
        {
            // input from how many numbers to get maxed number and chek if is equal to sum of others.
            int n = int.Parse(Console.ReadLine()); // input count of numbers
            int number = 0;
            int maxNumber = int.MinValue;
            int sumOtherNumbers = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
                sumOtherNumbers += number;
            }
            sumOtherNumbers -= maxNumber;
            if ( maxNumber == sumOtherNumbers)
            {
                Console.WriteLine("Yes sum = {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("No diff = {0}", Math.Abs(maxNumber - sumOtherNumbers));
            }
        }
    }
}
