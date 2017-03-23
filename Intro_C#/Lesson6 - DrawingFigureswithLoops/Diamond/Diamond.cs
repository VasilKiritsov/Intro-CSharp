using System;


namespace Diamond
{
    public class Diamond
    {
        public static void Main()
        {
            // get number from input and draw a diamond
            int num = int.Parse(Console.ReadLine());
            int leftRight = (num - 1) / 2;

            int middleDashCount = 0;
            if (num == 1)
            {
                Console.WriteLine("*");
                return;
            }

            if (num % 2 == 1)
            {
                Console.WriteLine(new string('-', num / 2) + "*" + new string('-', num / 2));
                middleDashCount++;
            }

            for (int i = 0; i < num / 2; i++)
            {
                Console.Write(new string('-', num /2-1- i));
                Console.Write("*");
                Console.Write(new string('-', middleDashCount + 2 * i));
                Console.Write("*");
                Console.WriteLine(new string('-', num / 2 - 1 - i));
            }

            for (int i = 0; i < num/2 -1; i++)
            {
                Console.Write(new string('-', 1 + i));
                Console.Write("*");
                Console.Write(new string('-', num - 4 - 2 * i));
                Console.Write("*");
                Console.WriteLine(new string('-', 1 + i));
            }

            if (num % 2 == 1)
            {
                Console.WriteLine(new string('-', num / 2) + "*" + new string('-', num / 2));
            }
        }
    }
}
