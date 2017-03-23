using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumSeconds
{
    class sumSeconds
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondSeconds = int.Parse(Console.ReadLine());
            int thridSeconds = int.Parse(Console.ReadLine());
            int sum = firstSeconds + secondSeconds + thridSeconds;
            if (sum < 59)
            {
                if (sum < 10)
                {
                    Console.WriteLine("0:0{0}", sum);
                }
                else
                {
                    Console.WriteLine("0:{0}", sum);
                }
            }
            else if (sum >= 60 && sum < 120)
            {
                if ((sum -60) < 10)
                {
                    Console.WriteLine("1:0{0}", sum - 60);
                }
                else
                {
                    Console.WriteLine("1:{0}", sum - 60);
                }
            }
            else if  (sum >= 120 && sum < 180)
            {
                if ((sum - 120) < 10)
                {
                    Console.WriteLine("2:0{0}", sum - 120);
                }
                else
                {
                    Console.WriteLine("2:{0}", sum - 120);
                }
            }

        }
    }
}
