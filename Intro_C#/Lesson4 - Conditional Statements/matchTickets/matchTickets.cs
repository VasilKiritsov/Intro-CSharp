using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchTickets
{
    class matchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int member = int.Parse(Console.ReadLine());

            double transportCost = 0;
            double ticketPrice = 0;
            if (category == "VIP")
            {
                ticketPrice = 499.99;
            }
            else
            {
                ticketPrice = 249.99;
            }

            if (member <= 4)
            {
                transportCost = 0.75;
            }
            else if (5 <= member && member <= 9)
            {
                transportCost = 0.60;
            }
            else if (10 <= member && member <= 24)
            {
                transportCost = 0.50;
            }
            else if (25 <= member && member <= 49)
            {
                transportCost = 0.40;
            }
            else if (member >= 50)
            {
                transportCost = 0.25;
            }

            double ticketBudget = budget - budget * transportCost;
            if (ticketBudget > member * ticketPrice)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", ticketBudget - member * ticketPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", member * ticketPrice - ticketBudget);
            }
        }
    }
}
