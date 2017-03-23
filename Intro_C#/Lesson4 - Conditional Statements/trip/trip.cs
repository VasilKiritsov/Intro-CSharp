using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trip
{
    class trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destinationCountry = "";
            string destination = "";
            double costs = 0;
            if (budget <= 100)
            {
                destinationCountry = "Bulgaria";
                if (season == "summer")
                {
                    destination = "Camp";
                    costs = 0.30;
                }
	else if (season == "winter")
                {
                    destination = "Hotel";
                    costs = 0.70;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destinationCountry = "Balkans";
                if (season == "summer")
                {
                    destination = "Camp";
                    costs = 0.40;
                }
                else if (season == "winter")
                {
                    destination = "Hotel";
                    costs = 0.80;
                }
            }
            else if (budget > 1000)
            {
                destinationCountry = "Europe";
                destination = "Hotel";
                costs = 0.90;
            }

            if (costs != 0)
            {
                Console.WriteLine("Somewhere in {0}", destinationCountry);
                Console.WriteLine("{0} - {1:f2}", destination, budget * costs);
            }
        }
    }
}
