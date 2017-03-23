using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poolPipe
{
    class poolPipe
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            
            var firstPipe = p1 * h;
            var secondPipe = p2 * h;
            var percentFull = (firstPipe + secondPipe) / v * 100;
            var percentFirstPipe = firstPipe / (firstPipe + secondPipe) * 100;
            percentFirstPipe = Math.Floor(percentFirstPipe);
            var percentSecondPipe = secondPipe / (firstPipe + secondPipe) * 100;
            percentSecondPipe = Math.Floor(percentSecondPipe);
            if ((firstPipe + secondPipe) <= v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",percentFull ,percentFirstPipe,percentSecondPipe);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,(firstPipe + secondPipe) - v);
            }

        }
    }
}
