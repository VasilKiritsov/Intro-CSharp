using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusScore
{
    class bonusScore
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonusPoint = 0;

            if (num <=100)
            {
                bonusPoint = 5;
                if(num % 2 == 0)
                {
                    bonusPoint += 1;
                }
                else if( num % 5 == 0)
                {
                    bonusPoint += 2;
                }
                Console.WriteLine(bonusPoint);
                Console.WriteLine(num + bonusPoint);
            }
            else if (num > 100 && num < 1000)
            {
                bonusPoint = num * 0.2;
                if (num % 2 == 0)
                {
                    bonusPoint += 1;
                }
                else if (num % 5 == 0)
                {
                    bonusPoint += 2;
                }
                Console.WriteLine(bonusPoint);
                Console.WriteLine(num + bonusPoint);
            }
            else
            {
                bonusPoint = num * 0.1;
                if (num % 2 == 0)
                {
                    bonusPoint += 1;
                }
                else if (num % 5 == 0)
                {
                    bonusPoint += 2;
                }
                Console.WriteLine(bonusPoint);
                Console.WriteLine(num + bonusPoint);
            }
        }
    }
}
