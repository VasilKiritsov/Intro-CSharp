﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((i != 1) && (i != n) && (j != 1) && (j != n))
                    {
                        Console.Write(" ");
                    }
		            else
		            {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}