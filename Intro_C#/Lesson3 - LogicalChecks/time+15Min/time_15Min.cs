using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_15Min
{
    class time_15Min
    {
        static void Main(string[] args)
        {
            uint hours = uint.Parse(Console.ReadLine());
           uint minutes = uint.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }
            if(hours > 23)
            {
                hours -= 24;
            }
            Console.WriteLine("{0}:{1:00}",hours,minutes);
        }
    }
}
