using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class money
    {
        static void Main(string[] args)
        {
            int coin = int.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());
            double usd = yuan * 0.15;
            double bgn = usd * 1.76;
            double eur = bgn / 1.95;
            var bgnCoin = coin * 1168 / 1.95;
            double eurResult = eur + bgnCoin;
            double commResult = commission / 100 * eurResult;
            Console.WriteLine(eurResult - commResult);
        }
    }
}
