using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyConverter
{
    class currencyConverter
    {
        static void Main(string[] args)
        {
            var valut = double.Parse(Console.ReadLine());
            string choice = Console.ReadLine();
            string secChoice = Console.ReadLine();

            var bgn = 1.0;
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;

            double result = 0;
            switch (choice)
            {
                case "BGN": valut = valut * bgn;
                     break;
                case "USD": valut = valut * usd;
                    break;
                case "EUR": valut = valut * eur;
                     break;
                case "GBP": valut = valut * gbp;
                     break;
                default:
                    break;
            }
            switch (secChoice)
            {
                case "BGN": result = valut / bgn;
                    break;
                case "USD": result = valut / usd;
                    break;
                case "EUR": result = valut / eur;
                    break;
                case "GBP": result = valut / gbp;
                    break;
                default:
                    break;
            }
            Console.WriteLine(Math.Round(result, 2) + " " + secChoice);
        }
    }
}
