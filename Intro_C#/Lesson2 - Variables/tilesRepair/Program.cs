using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tilesRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            int maxArea = n * n;
            int bench = m * o;
            var tiles = w * l;
            int workArea = maxArea - bench;
            var tilesArea = workArea / tiles;
            var time = tilesArea * 0.2;
            Console.WriteLine(tilesArea);
            Console.WriteLine(time);
        }
    }
}
