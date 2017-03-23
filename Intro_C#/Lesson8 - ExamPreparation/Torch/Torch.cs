using System;


namespace Torch
{
    public class Torch
    {
        public static void Main()
        {
            // get number from input and draw a torch
            int num = int.Parse(Console.ReadLine());

            int pointPerSide = num / 2 - 1;
            int heigh = num / 2;
            int pointInside = 0;

            for (int i = 0; i < heigh; i++)
            {
                pointInside = i * 2;
                Console.WriteLine("{0}#{1}#{0}", new string('.', pointPerSide - i), new string('.', pointInside));
            }

            int pointPerSideMid = 0;
            int pointInsideMid = num - (pointPerSideMid * 2 + 2);

            for (int j = 0; j < num / 4; j++)
            {    
                Console.WriteLine("{0}#{1}#{0}", new string('.', pointPerSideMid), new string('.', pointInsideMid));
                pointPerSideMid++;
                pointInsideMid -= 2;
            }

            Console.WriteLine("{0}", new string('-', num));

            for (int k = 0; k < heigh; k++)
            {
                Console.WriteLine("{0}{1}{2}{0}", new string('.', k), new string('\\',heigh - k),
                    new string('/', heigh - k));
            }
        }
    }
}
