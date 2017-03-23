using System;

namespace Histogram
{
    public class Histogram
    {
        static void Main()
        {
            // get n numbers from input and print histogram
            int n = int.Parse(Console.ReadLine()); // get how mutch numbers will be inputed
            int number = 0;
            decimal p1 = 0.0m;      // numbers lower then 200
            decimal p2 = 0.0m;      // numbers betwen 200 and 399
            decimal p3 = 0.0m;      // numbers betwen 400 and 599
            decimal p4 = 0.0m;      // numbers betwen 600 and 799
            decimal p5 = 0.0m;      // numbers greater then 800

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if(number < 200)
                {
                    p1++;
                }
                else if (200 <= number && number < 400)
                {
                    p2++;
                }
                else if (400 <= number && number < 600)
                {
                    p3++;
                }
                else if (600 <= number && number < 800)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }
            }
            PrintResult(GetCountPercent(p1, n));
            PrintResult(GetCountPercent(p2, n));
            PrintResult(GetCountPercent(p3, n));
            PrintResult(GetCountPercent(p4, n));
            PrintResult(GetCountPercent(p5, n));
        }

        public static decimal GetCountPercent(decimal count, int numbers)
        {
            decimal result = count / numbers * 100;
            return result;
        }

        public static void PrintResult(decimal result)
        {
            Console.WriteLine("{0:0.00}%",result);
        }
    }
}
