using System;


namespace RoadSignStop
{
    public class RoadSignStop
    {
        public static void Main()
        {
            // get number from input and draw a road sign "STOP"
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', num + 1), new string('_', (num * 2) + 1));

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', num - i),
                    new string('/', 2), new string('_', (num * 2 - 1) + 2* i), new string('\\', 2));
            }

            Console.WriteLine("{0}{1}STOP!{1}{2}", new string('/', 2), new string('_', (num * 2) - 3),
                new string('\\', 2));

            for (int i = num; i >= 1; i--)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', num - i),
                    new string('\\', 2), new string('_', (num * 2 - 1) + 2 * i), new string('/', 2));
            }
        }
    }
}
