using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalType
{
    class animalType
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string animalType = "";
            switch(animal)
            {
                case "dog":
                    animalType = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    animalType = "reptile";
                    break;
                default:
                    animalType = "unknown";
                    break;
            }
            Console.WriteLine(animalType);
        }
    }
}
