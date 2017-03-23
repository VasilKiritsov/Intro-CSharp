using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddPositions
{
    public class EvenOddPositions
    {
        static void Main(string[] args)
        {
            // get inputed number and find all even and odd sum betwen 1 and number,
            // find max number betwen 1 and number
            int inputNumber = int.Parse(Console.ReadLine()); // get numbers length
            double numbers = 0;
            double evenMax = -10000.0;
            double evenMin = 10000.0;
            double evenSum = 0;
            double oddMax = -10000.0;
            double oddMin = 10000.0;
            double oddSum = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                numbers = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (evenMax < numbers)
                    {
                        evenMax = numbers;
                    }
                    if (evenMin > numbers)
                    {
                        evenMin = numbers;
                    }
                    evenSum += numbers;
                }
                else if (i % 2 != 0)
                {
                    if (oddMax < numbers)
                    {
                        oddMax = numbers;
                    }
                    if (oddMin > numbers)
                    {
                        oddMin = numbers;
                    }
                    oddSum += numbers;
                }
            }
            if (inputNumber == 0)
            {
                oddSum = 0;
                oddMin = 0;
                oddMax = 0;
                evenSum = 0;
                evenMin = 0;
                evenMax = 0;
                Console.WriteLine("OddSum = {0},", oddSum);
                Console.WriteLine("OddMin = No");
                Console.WriteLine("OddMax = No");
                Console.WriteLine("EvenSum = {0},", evenSum);
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                if (evenMax == -10000.0 && evenMin == 10000.0)
                {
                    Console.WriteLine("OddSum = {0},", oddSum);
                    Console.WriteLine("OddMin = {0},", oddMin);
                    Console.WriteLine("OddMax = {0},", oddMax);
                    Console.WriteLine("EvenSum = {0},", evenSum);
                    Console.WriteLine("EvenMin = No");
                    Console.WriteLine("EvenMax = No");
                }
                else if (oddMax == -10000.0 && oddMin == 10000.0)
                {
                    Console.WriteLine("OddSum = {0},", oddSum);
                    Console.WriteLine("EvenMin = No");
                    Console.WriteLine("EvenMax = No");
                    Console.WriteLine("EvenSum = {0},", evenSum);
                    Console.WriteLine("EvenMin = {0},", evenMin);
                    Console.WriteLine("EvenMax = {0}", evenMax);
                }
                else
                {
                    Console.WriteLine("OddSum = {0},", oddSum);
                    Console.WriteLine("OddMin = {0},", oddMin);
                    Console.WriteLine("OddMax = {0},", oddMax);
                    Console.WriteLine("EvenSum = {0},", evenSum);
                    Console.WriteLine("EvenMin = {0},", evenMin);
                    Console.WriteLine("EvenMax = {0}", evenMax);
                }
            }
        }
    }
}
