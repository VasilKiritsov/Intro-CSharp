using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleFace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number \"a\" : ");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter number \"b\" : ");
            var b = decimal.Parse(Console.ReadLine());
            Console.Write("The result is : ");
            Console.WriteLine(a * b);
        }
    }
}
