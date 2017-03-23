using System;


namespace LatterCombination
{
    public class LatterCombination
    {
        public static void Main()
        {
            // get 3 latters from input and write all combinations with
            char firstLatter = char.Parse(Console.ReadLine());
            char secondLatter = char.Parse(Console.ReadLine());
            char thridLatter = char.Parse(Console.ReadLine());
            int count = 0;

            for (char i = firstLatter; i <= secondLatter; i++)
            {
                for (char j = firstLatter; j <= secondLatter; j++)
                {
                    for (char k = firstLatter; k <= secondLatter; k++)
                    {
                        if (i != thridLatter && j != thridLatter && k != thridLatter)
                        {
                            Console.Write("{0}{1}{2}", i, j, k);
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(" {0}", count);
        }
    }
}
