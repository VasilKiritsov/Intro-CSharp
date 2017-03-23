using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    public class VowelsSum
    {
        static void Main(string[] args)
        {
            // input string and get vowel and then sum 
            string input = Console.ReadLine();
            char[] charArray = new char[input.Length];
            charArray = input.ToCharArray(); // make array from inputed string
            int vowelSum = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                //if (charArray[i] == 'a') // firs way with if statements //
                //{
                //    vowelSum += 1;
                //}
                //if (charArray[i] == 'e')
                //{
                //    vowelSum += 2;
                //}
                //if (charArray[i] == 'i')
                //{
                //    vowelSum += 3;
                //}
                //if (charArray[i] == 'o')
                //{
                //    vowelSum += 4;
                //}
                //if (charArray[i] == 'u')
                //{
                //    vowelSum += 5;
                //}
                switch(charArray[i])
                {
                    case 'a': vowelSum += 1; 
                        break;
                    case 'e':
                        vowelSum += 2; 
                        break;
                    case 'i':
                        vowelSum += 3; 
                        break;
                    case 'o':
                        vowelSum += 4; 
                        break;
                    case 'u':
                        vowelSum += 5; 
                        break;
                }
            }
            Console.WriteLine(vowelSum);
        }
    }
}
