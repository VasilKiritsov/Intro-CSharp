using System;


namespace Castle
{
    public class Castle
    {
        public static void Main()
        {
            // get number from input and draw a castle
            int num = int.Parse(Console.ReadLine());
            int midOfCastle = num * 2 - 4 - 2 * (num / 2);

            Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", new string('/', 1), new string('^', num / 2),
                new string('\\', 1), new string('_', midOfCastle));

            for (int i = 0; i < num - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', num * 2 - 2));
            }

            Console.WriteLine("|{0}{1}{0}|", new string(' ', num / 2 + 1), new string('_', midOfCastle));
            Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", new string('\\', 1), new string('_', num / 2),
                new string('/', 1), new string(' ', midOfCastle));
        }
    }
}
