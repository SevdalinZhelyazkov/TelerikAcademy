using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsWord
{
    class DigitAsWord
    {
        static void LastDigitWord(int number)
        {
            number %= 10;
            switch(number)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                default:
                    Console.WriteLine("nine");
                    break;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            LastDigitWord(n);
        }
    }
}
