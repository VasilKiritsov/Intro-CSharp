using System;


namespace House
{
    public class House
    {
        public static void Main()
        {
            // get number from input and draw a house
            int num = int.Parse(Console.ReadLine());

            int stars = 1;
            if (num % 2 == 0)
            {
                stars++;
            }

            for (int i = 1; i <= (num + 1) / 2; i++)  // draw the roof
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (num - stars)/2), new string('*', stars));
                stars += 2;
            }

            for (int i = 1; i <= num / 2 ; i++) // base
            {
                Console.WriteLine("{0}{1}{0}", new string('|', 1), new string('*', num - 2));
            }

        }
    }
}
