﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidNumber
{
    class invalidNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            if(number == 0 || number >= 100 && number <= 200)
            {
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
