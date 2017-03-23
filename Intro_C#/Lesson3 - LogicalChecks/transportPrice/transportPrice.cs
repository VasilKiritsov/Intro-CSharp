using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportPrice
{
    class transportPrice
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayNihgt = Console.ReadLine();

            double dayTaxiPrice = n * 0.79 + 0.70;
            double nightTaxiPrice = n * 0.90 + 0.70;
            double busPrice = n * 0.09;
            double trainPrice = n * 0.06;

            if(n < 20 && dayNihgt == "day")
            {
                Console.WriteLine(dayTaxiPrice);
            }
            else if(n < 20 && dayNihgt == "night")
            {
                Console.WriteLine(nightTaxiPrice);
            }
            else if(n >= 20 && n < 100)
            {
                Console.WriteLine(busPrice);
            }
            else
            {
                Console.WriteLine(trainPrice);
            }
        }
    }
}
