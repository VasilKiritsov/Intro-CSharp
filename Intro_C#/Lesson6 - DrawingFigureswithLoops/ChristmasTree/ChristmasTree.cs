using System;


namespace ChristmasTree
{
    public class ChristmasTree
    {
        static void Main()
        {
            // get number from input and draw a chrismas tree
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string(' ', num + 1), new string('|', 1));
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string(' ', num - i), new string('*', i), new string(' ', 1), new string('|', 1));
            }
        }
    }
}
