using System;


namespace BirdsInPark
{
    public class BirdsInPark
    {
        public static void Main()
        {
            //get two numbers from input, first is how many birds have in the park,
            // second is how many birds feather have in park and write each birds feather

            int birdsInPark = int.Parse(Console.ReadLine());
            int featherInPark = int.Parse(Console.ReadLine());

            if (birdsInPark == 0 && featherInPark == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                double eachBirdFeather = (double)featherInPark / birdsInPark;
                if (birdsInPark % 2 == 0)
                {
                    eachBirdFeather *= 123123123123;
                }
                else
                {
                    eachBirdFeather /= 317;
                }

                Console.WriteLine("{0:f4}", eachBirdFeather);
            }
        }
    }
}
