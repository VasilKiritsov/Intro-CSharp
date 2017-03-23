using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingLab
{
    class trainingLab
    {
        static void Main(string[] args)
        {
            
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var row = h * 100 / 120;
            var col = (w - 1) * 100 / 70;
            var positions = Math.Floor(row) * Math.Floor(col) - 3;
            Console.WriteLine(positions);
        }
    }
}
