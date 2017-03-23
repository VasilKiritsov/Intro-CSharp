using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harvest
{
    class harvest
    {
        static void Main(string[] args)
        {
            int fullVineyard = int.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            int neededVine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapesForWine = fullVineyard * grapes;
            double wine = 0.4 * grapesForWine / 2.5;
                if (wine >= neededVine)
                {
                    Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                    Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - neededVine), Math.Ceiling((wine - neededVine) / workers));
                }
                else
                {
                    Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededVine - wine));
                }
        }
    }
}
