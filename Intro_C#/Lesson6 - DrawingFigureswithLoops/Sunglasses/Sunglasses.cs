using System;


namespace Sunglasses
{
    public class Sunglasses
    {
        static void Main()
        {
            // get number from input and draw a sunglasses
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * num), new string(' ', num));
            string frame = "";
            for (int i = 0; i < num - 2; i++)
            {
                if (i == (num - 1) / 2 - 1)
                {
                    frame = new string('|', num);
                }
                else
                {
                    frame = new string(' ', num);
                }
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*',1), new string('/',num * 2 - 2), frame);
            }
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * num), new string(' ', num));
        }
    }
}
