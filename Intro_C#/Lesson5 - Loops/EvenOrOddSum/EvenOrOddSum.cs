using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddSum
{
    public class EvenOrOddSum
    {
        static void Main(string[] args)
        {
            // input how many numbers for summ
            int n = int.Parse(Console.ReadLine()); // count of numbers

            int number = 0;
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            if(evenSum == oddSum)
            {
                Console.WriteLine("Yes sum " + evenSum);
            }
            else
            {
                Console.WriteLine("No diff " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}
