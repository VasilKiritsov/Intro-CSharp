using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointInTheFigure
{
    class pointInTheFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((y == 0 && 0< x && x <= 3*h) || ( y == h && ((2*h <= x && x<= 3*h) || (0<x && x <= h))) ||
                (y == 4*h && h <= x && x <= 2 *h) || ((x == h || x== 2*h) && h <=y && y <= 4*h) ||
                    (x == 3*h && 0 < y && y <= h) || (x == 0 && y <=h))
            {
                Console.WriteLine("border");
            }
            else if ((0 < x && x < 3*h && 0<y && y < h) || (h < x && x < 2*h && y < 4*h) || (0 < y && y < h && 0 < x && x < 3*h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
