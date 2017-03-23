using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class cinema
    {
        static void Main(string[] args)
        {
            string projectType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double price = 0;
            if ( projectType == "Premiere")
            {
                price = 12.00;
            }
            else if (projectType == "Normal")
            {
                price = 7.50;
            }
            else if (projectType == "Discount")
            {
                price = 5.00;
            }
            Console.WriteLine("{0:f2} leva",row *col * price);

        }
    }
}
