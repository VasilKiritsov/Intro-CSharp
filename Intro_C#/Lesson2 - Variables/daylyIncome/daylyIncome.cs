using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daylyIncome
{
    class daylyIncome
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());
            var valut = double.Parse(Console.ReadLine());
            var mounthCheck = days * money;
            var yearCheck = mounthCheck * 12 + mounthCheck * 2.5;
            var tax = 25 * yearCheck / 100;
            var yearIncome = (yearCheck - tax) * valut;
            var daylyIncome = yearIncome / 365;
            Console.WriteLine(Math.Round(daylyIncome,2));
        }
    }
}
