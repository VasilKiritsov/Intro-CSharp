using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    if (nights > 14)
                    {
                        studioPrice -= studioPrice * 0.3;
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (nights > 14)
                    {
                        studioPrice -= studioPrice * 0.2;
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    if (nights > 14)
                    {
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice * nights);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice * nights);
        }
    }
}
