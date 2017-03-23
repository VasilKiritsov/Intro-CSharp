using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onTimeForExam
{
    class onTimeForExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMinutes = int.Parse(Console.ReadLine());
            int hours = 0;
            int minutes = 0;
            int examTime = examHour * 60 + examMinutes;
            int studentTime = studentHour * 60 + studentMinutes;
            int differenceMinutes = studentTime - examTime;

            if (differenceMinutes < -30)
            {
                Console.WriteLine("Early");
            }
            else if (differenceMinutes <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }
            if (differenceMinutes != 0)
            {
                hours = Math.Abs(differenceMinutes / 60);
                minutes = Math.Abs(differenceMinutes % 60);
                if (hours > 0)
                {
                    if (minutes < 10)
                    {
                        Console.Write(hours + ":0" + minutes + " hours");
                    }
                    else
                    {
                        Console.Write(hours + ":" + minutes + " hours");
                    }
                }
                else
                {
                    Console.Write(minutes + " minutes");
                }
                if (differenceMinutes < 0)
                {
                    Console.WriteLine(" before the start");
                }
                else
                {
                    Console.WriteLine(" after the start");
                }
            }
        }
    }
}
