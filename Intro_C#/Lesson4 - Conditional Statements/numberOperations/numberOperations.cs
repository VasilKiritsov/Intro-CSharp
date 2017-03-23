using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberOperations
{
    class numberOperations
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            char choice = char.Parse(Console.ReadLine());

            double result = 0;
            string evenOdd = "";

            if (choice == '+')
            {
                result = firstNum + secondNum;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNum, choice, secondNum, result, evenOdd);
            }
            if (choice == '-')
            {
                result = firstNum - secondNum;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNum, choice, secondNum, result, evenOdd);
            }
            if (choice == '*')
            {
                result = firstNum * secondNum;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNum, choice, secondNum, result, evenOdd);
            }
            if (choice == '/')
            {
                if (secondNum == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNum);
                }
                else
                {
                    result = firstNum / secondNum;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", firstNum, choice, secondNum, result);
                }
            }
            if (choice == '%')
            {
                if (secondNum == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNum);
                }
                else
                {
                    result = firstNum % secondNum;
                    Console.WriteLine("{0} {1} {2} = {3}", firstNum, choice, secondNum, result);
                }
                
            }
        }
    }
}
