using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysAfterBirth1000
{
    class daysAfterBirth1000
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            date = date.AddDays(999);
            Console.WriteLine("{0: dd-MM-yyyy}", date);
        }
    }
}
