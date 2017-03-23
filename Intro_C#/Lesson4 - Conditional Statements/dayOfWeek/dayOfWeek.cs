using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayOfWeek
{
    class dayOfWeek
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string dayOfWeek = "";
            switch(number)
            {
                case 1: dayOfWeek = "Monday";
                        break;
                case 2:
                    dayOfWeek = "Tuesday";
                    break;
                case 3:
                    dayOfWeek = "Wednesday";
                    break;
                case 4:
                    dayOfWeek = "Thursday";
                    break;
                case 5:
                    dayOfWeek = "Friday";
                    break;
                case 6:
                    dayOfWeek = "Saturday";
                    break;
                case 7:
                    dayOfWeek = "Sunday";
                    break;
                default: dayOfWeek = "Error";
                    break;
            }
            Console.WriteLine(dayOfWeek);
        }
    }
}
