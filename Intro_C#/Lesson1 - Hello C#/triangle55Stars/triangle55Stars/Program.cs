using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "*";
            for (int i = 0; i < 10; i++ )
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0}",s);
                }
                Console.WriteLine();
            }
        }
    }
}
