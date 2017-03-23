using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDemo
{
    class LiveDemo
    {
        static void Main(string[] args)
        {
            //*1*// kakvo pravi pilot 5 dni i koi den e?
            //Console.WriteLine(1);
            //Console.WriteLine("Stavam sutrin.");
            //Console.WriteLine("Izlizam na pistata.");
            //Console.WriteLine("Karam cql den");
            //Console.WriteLine("Pribiram se.");

            //Console.WriteLine(2);
            //Console.WriteLine("Stavam sutrin.");
            //Console.WriteLine("Izlizam na pistata.");
            //Console.WriteLine("Karam cql den");
            //Console.WriteLine("Pribiram se.");

            //Console.WriteLine(3);
            //Console.WriteLine("Stavam sutrin.");
            //Console.WriteLine("Izlizam na pistata.");
            //Console.WriteLine("Karam cql den");
            //Console.WriteLine("Pribiram se.");

            //Console.WriteLine(4);
            //Console.WriteLine("Stavam sutrin.");
            //Console.WriteLine("Izlizam na pistata.");
            //Console.WriteLine("Karam cql den");
            //Console.WriteLine("Pribiram se.");

            //Console.WriteLine(5);
            //Console.WriteLine("Stavam sutrin.");
            //Console.WriteLine("Izlizam na pistata.");
            //Console.WriteLine("Karam cql den");
            //Console.WriteLine("Pribiram se.");

            //for (int i = 1; i <=5; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("Stavam sutrin.");
            //    Console.WriteLine("Izlizam na pistata.");
            //    Console.WriteLine("Karam cql den");
            //    Console.WriteLine("Pribiram se.");
            //}



            //*7*// exercise from homework.
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum += number;
            }

            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }
        }
    }
}
