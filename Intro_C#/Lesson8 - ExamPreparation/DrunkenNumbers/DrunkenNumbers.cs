using System;


namespace DrunkenNumbers
{
    public class DrunkenNumbers
    {
        public static void Main()
        {
            // get from input how many rounds have M - Mitko and N - Vladko and write the winner

            int numberOfRounds = int.Parse(Console.ReadLine());
            int drunkenNumber = 0;
            int mitkoBreers = 0;
            int vladkoBeers = 0;

            for (int i = 0; i < numberOfRounds; i++)
            {
                drunkenNumber = int.Parse(Console.ReadLine());
                drunkenNumber = Math.Abs(drunkenNumber);
                int numberDigits = GetNumberDigits(drunkenNumber);
                
                if (numberDigits % 2 == 0)
                {
                    // mitko gets first half of number
                    // vladko gets second half of number
                    for (int j = 0; j < numberDigits / 2; j++)
                    {
                        vladkoBeers += drunkenNumber % 10;
                        drunkenNumber /= 10;
                    }

                    for (int j = 0; j < numberDigits / 2; j++)
                    {
                        mitkoBreers += drunkenNumber % 10;
                        drunkenNumber /= 10;
                    }
                }
                else
                {
                    // mitko gets first half + middle digit of number
                    // vladko gets middle digit + second half of number
                    for (int j = 0; j < numberDigits / 2; j++)
                    {
                        vladkoBeers += drunkenNumber % 10;
                        drunkenNumber /= 10;
                    }

                    // get middle digit
                    int middleDigit = drunkenNumber % 10;
                    vladkoBeers += middleDigit;
                    mitkoBreers += middleDigit;
                    drunkenNumber /= 10;

                    for (int j = 0; j < numberDigits / 2; j++)
                    {
                        mitkoBreers += drunkenNumber % 10;
                        drunkenNumber /= 10;
                    }
                }
            }

            if (mitkoBreers > vladkoBeers)
            {
                Console.WriteLine("M {0}", mitkoBreers - vladkoBeers);
            }
            else if (vladkoBeers > mitkoBreers)
            {
                Console.WriteLine("V {0}", vladkoBeers - mitkoBreers);
            }
            else
            {
                Console.WriteLine("No {0}", mitkoBreers + vladkoBeers);
            }
        }

        public static int GetNumberDigits(int number)
        {
            int numberDigits = 0;
            int tempDrunkenNumber = number;

            while (tempDrunkenNumber > 0)
            {
                tempDrunkenNumber /= 10;
                numberDigits++;
            }

            return numberDigits;
        }
    }
}
