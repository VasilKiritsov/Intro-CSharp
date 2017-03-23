using System;


namespace ChekIfNumberIsEven
{
    public class ChekIfNumberIsEven
    {
        public static void Main()
        {
            // get number from input and chek if is even with try ... catch
            int number = 0;

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                    else
                    {
                        break;
                    }

                    Console.WriteLine("Even number entered : {0}", number);
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            Console.WriteLine("Even number entered : {0}", number);

        }
    }
}
