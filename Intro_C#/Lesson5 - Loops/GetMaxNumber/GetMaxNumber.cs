using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxNumber
{
    public class GetMaxNumber
    {
        static void Main(string[] args)
        {
            // input from how many numbers to get maxed number
            int n = int.Parse(Console.ReadLine()); // input count of numbers
            int number = 0;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
