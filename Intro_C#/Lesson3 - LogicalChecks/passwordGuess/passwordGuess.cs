using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordGuess
{
    class passwordGuess
    {
        static void Main(string[] args)
        {
            string inputPass = Console.ReadLine();
            string userPass = "s3cr3t!P@ssw0rd";
            if (inputPass == userPass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
