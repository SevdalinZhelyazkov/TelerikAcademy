using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class HelloName
    {
        static string SayHello(string name)
        {
            string result = string.Format("Hello, {0}!", name);
            return result;
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(SayHello(name));
        }
    }
}
