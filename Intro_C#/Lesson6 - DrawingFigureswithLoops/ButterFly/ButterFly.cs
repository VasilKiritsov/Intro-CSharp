using System;


namespace ButterFly
{
    public class ButterFly
    {
        public static void Main()
        {
            // get number from input and draw butterfly
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', num - 2), new string('\\', 1),
                        new string(' ', 1), new string('/', 1));

            for (int i = 1; i < num - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', num - 2), new string('\\', 1),
                        new string(' ', 1), new string('/', 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('-', num - 2), new string('\\', 1),
                        new string(' ', 1), new string('/', 1));
                }
            }

            Console.WriteLine("{0}{1}", new string(' ', num - 1), new string('@', 1));

            for (int i = 1; i < num - 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', num - 2), new string('/', 1),
                        new string(' ', 1), new string('\\', 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('-', num - 2), new string('/', 1),
                        new string(' ', 1), new string('\\', 1));
                }
            }

            Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', num - 2), new string('/', 1),
                        new string(' ', 1), new string('\\', 1));
        }
    }
}
