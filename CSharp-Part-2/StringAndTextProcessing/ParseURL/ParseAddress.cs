using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseAddress
    {
        static string ParseURL(string url)
        {
            string protocol = "";
            string server = "";
            string resource = "";

            int startIndex = 0;
            int colonIndex = url.IndexOf(':');
            if (colonIndex != -1)
            {
                protocol = url.Substring(startIndex, colonIndex - startIndex);
            }

            startIndex = colonIndex + 3;

            char dirSlash = '/';
            int slashIndex = url.IndexOf(dirSlash, startIndex);
            if (slashIndex != -1)
            {
                server = url.Substring(startIndex, slashIndex - startIndex);
                resource = url.Substring(slashIndex);
            }
            else
            {
                server = url.Substring(startIndex);
            }

            string result = string.Format("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", protocol, server, resource);
            return result;
        }
        static void Main(string[] args)
        {
            string address = Console.ReadLine();
            Console.WriteLine(ParseURL(address));
        }
    }
}
