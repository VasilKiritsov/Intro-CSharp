using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    public class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            // input number for left and right sum
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int firstNumber = 0;
            int nextNumbers = 0;
            for (int i = 0; i < n; i++)
            {
                firstNumber = int.Parse(Console.ReadLine());
                leftSum += firstNumber;
            }
            for (int i = 0; i < n; i++)
            {
                nextNumbers = int.Parse(Console.ReadLine());
                rightSum += nextNumbers;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes sum " + leftSum);
            }
            else
            {
                Console.WriteLine("No diff " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
