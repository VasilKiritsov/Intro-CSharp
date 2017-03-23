using System;


namespace LiveDemo
{
    public class LiveDemo
    {
        static void Main()
        {
            /* 1 make a electronical watch*/
            //for (int h = 0; h <= 23; h++)
            //{
            //    for (int m = 0; m <= 59; m++)
            //    {
            //        Console.WriteLine("{0:00} : {1:00}", h, m);
            //    }
            //}



            /* 2 make a rechtangle with '*' */
            //int n = int.Parse(Console.ReadLine());
            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            /* 3 make a rechtangle with '*' , other solution*/
            //for (int i = 0; i < 10; i++)
            //{
            //    string row = new string('*', 10);
            //    Console.WriteLine(row);
            //}


            /* 4  get number from input and draw diamond */
            //int num = int.Parse(Console.ReadLine());

            //int starsInTop = 0;
            //if (num % 2 == 1)
            //{
            //    starsInTop = 1;
            //}
            //else
            //{
            //    starsInTop = 2;
            //}

            //int dashesInTop = (num - starsInTop) / 2;
            //Console.WriteLine("{0}{1}{0}", new string('-',dashesInTop), new string('*',starsInTop));

            //int dashesBetweenStars = 0;
            //if (num%2 == 1)
            //{
            //    dashesBetweenStars = x
            //}
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("{0);
            //}


            //Console.WriteLine("{0}{1}{0}", new string('-', dashesInTop), new string('*', starsInTop));


            /*5 get number from input and draw a house */

            //int n = int.Parse(Console.ReadLine());

            //int roofHeight = 0;
            //if (roofHeight % 2 == 0)
            //{
            //    roofHeight = n / 2;
            //}
            //else
            //{
            //    roofHeight = n / 2 + 1;
            //}

            /*6 heart */

            char o = 'o';
            Console.WriteLine("  " + o + o + o + "   " + o + o + o);
            Console.WriteLine(" " + o + "   " + o + " " + o + "   " + o);
            Console.WriteLine(o + "     " + o + "     " + o);
            Console.WriteLine(o + " Обичам те " + o);
            Console.WriteLine(o + "     " + " " + "     " + o);
            Console.WriteLine(" " + o + "  Ми" + "ло!  " + o);
            Console.WriteLine("  " + o + "   " + "    " + o);
            Console.WriteLine("   " + o + "  " + "   " + o);
            Console.WriteLine("    " + o + "  " + " " + o);
            Console.WriteLine("     " + o + " " + o);
            Console.WriteLine("      " + o);
        }// обичам те!
    }
}

