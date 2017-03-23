using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneToHundertText
{
    class oneToHundertText
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tens = num / 10 % 10;
            int ones = num % 10;
            string result = "";

            if (num < 100)
            {
                switch (tens)
                {
                    case 1:
                        switch (ones)
                        {

                            case 0: result += "ten";
                                break;
                            case 1: result += "eleven";
                                break;
                            case 2: result += "twelve";
                                break;
                            case 3: result += "thirteen";
                                break;
                            case 4: result += "fourteen";
                                break;
                            case 5: result += "fifteen";
                                break;
                            case 6: result += "sixteen";
                                break;
                            case 7: result += "seventeen";
                                break;
                            case 8: result += "eightteen";
                                break;
                            case 9: result += "nineteen";
                                break;
                            default: 
                                break;
                        }
                        break;
                    case 2: result += "twenty";
                        break;
                    case 3: result += "thirty";
                        break;
                    case 4: result += "fourty";
                        break;
                    case 5: result += "fifty";
                        break;
                    case 6: result += "sixty";
                        break;
                    case 7: result += "seventy";
                        break;
                    case 8: result += "eighty";
                        break;
                    case 9: result += "ninety";
                        break;
                    default: break;
                }
                if (tens > 1 && ones > 0)
                {
                    result += " ";
                }
                if (tens != 1)
                {

                    switch (ones)
                    {
                        case 0:
                            if (tens == 0 && ones == 0)
                            {
                                result += "zero";
                            }
                            break;
                        case 1: result += "one";
                            break;
                        case 2: result += "two";
                            break;
                        case 3: result += "three";
                            break;
                        case 4: result += "four";
                            break;
                        case 5: result += "five";
                            break;
                        case 6:  result += "six";
                            break;
                        case 7: result += "seven";
                            break;
                        case 8: result += "eight";
                            break;
                        case 9: result += "nine";
                            break;
                        default:
                            break;
                    }
                }
            }
            if (num == 100)
            {
                result += "one hundred";
            }
            if (num > 100 || num < 0)
            {
                result += "invalid number";
            }
                Console.WriteLine(result);
            }
        }
    }
