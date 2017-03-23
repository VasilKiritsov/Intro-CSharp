using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumberToN
{
    public class SumNumberToN
    {
        static void Main(string[] args)
        {
            // get how many numbers will input and sum numbers
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int numberForSum = 0;
            for ( int i = 0; i < number; i++)
            {
                numberForSum = int.Parse(Console.ReadLine());
                sum += numberForSum;
            }
            Console.WriteLine(sum);
        }
    }
}
