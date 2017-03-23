using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lazyCatTom
{
    class lazyCatTom
    {
        static void Main(string[] args)
        {
            int dayOff = int.Parse(Console.ReadLine());
            int playNorm = 30000;
            int playTime = (365 - dayOff) * 63 + dayOff * 127;
            int hours = 0;
            int minutes = 0;

            if (playTime > playNorm)
            {
                hours = (playTime - playNorm) / 60;
                minutes = ((playTime - playNorm) % 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                hours = (playNorm - playTime) / 60;
                minutes = ((playNorm - playTime) % 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
