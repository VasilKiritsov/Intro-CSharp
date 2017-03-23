using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball
{
    class volleyball
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holydayInYear = int.Parse(Console.ReadLine());
            int weekendsInHomeTown = int.Parse(Console.ReadLine());

            double holidayVolleyballDays = 2 * holydayInYear / 3.0;
            int weekendsInSofia = 48 - weekendsInHomeTown;
            double nonWorkingWeekendsInSofia = 3.0 * weekendsInSofia / 4.0;
            double volleyballWeekendsInSofia = nonWorkingWeekendsInSofia;
            int volleyballDaysInHomeTown = weekendsInHomeTown;

            double totalVolleyballDaysInYear = holidayVolleyballDays + volleyballWeekendsInSofia
                + volleyballDaysInHomeTown;
            if (yearType == "leap")
            {
                totalVolleyballDaysInYear *= 1.15;
            }
            Console.WriteLine((int)totalVolleyballDaysInYear);
        }
    }
}
