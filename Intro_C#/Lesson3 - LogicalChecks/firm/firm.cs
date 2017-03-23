using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firm
{
    class firm
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int disposableDays = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            double workDays = disposableDays - (disposableDays * 0.1);
            double overtimeHours = (disposableDays * 2) * overtimeWorkers;
            double workHours = workDays * 8 + overtimeHours;
            workHours = Math.Floor(workHours);

            if (neededHours <= workHours)
            {
                Console.WriteLine("Yes!{0} hours left.", workHours - neededHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", neededHours - workHours);
            }
        }
    }
}
