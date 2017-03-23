using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitOrVegetable
{
    class fruitOrVegetable
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();

            switch(productName)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                        break;
            }
            //if (productName == "banana" ||
            //    productName == "aple" ||
            //    productName == "kiwi" ||
            //    productName == "cherry" ||
            //    productName == "lemon" ||
            //    productName == "grapes") ;
            //{
            //    Console.WriteLine("fruit");
            //}
            //else if (productName == "tomato" ||
            //    productName == "cucumber" ||
            //    productName == "pepper" ||
            //    productName == "carrot");
            //{
            //    Console.WriteLine("vegetable");
            //}
            //else
            //{
            //    Console.WriteLine("unknown");
            //}
        }
    }
}
