using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class ReplaceNotation
    {
        static string ReplaceHTMLTags(string html)
        {
            StringBuilder result = new StringBuilder();
            int index = 0;
            while (true)
            {
                // get part before <a href and append
                int elementStart = html.IndexOf("<a", index);
                if (elementStart == -1)
                {
                    string elementAfter = html.Substring(index);
                    result.Append(elementAfter);
                    break;
                }
                string elementBefore = html.Substring(index, elementStart - index);
                result.Append(elementBefore);

                // store URL
                int elementHrefEnd = html.IndexOf("\"", elementStart + 9);
                string elementURL = html.Substring(elementStart + 9, elementHrefEnd - elementStart - 9);

                // store Value
                int elementFirstEnd = html.IndexOf(">", elementHrefEnd);
                int elementLastEnd = html.IndexOf("</a>", elementHrefEnd);
                string elementValue = html.Substring(elementFirstEnd + 1, elementLastEnd - elementFirstEnd - 1);

                index = elementLastEnd + 4;

                string currentAdd = string.Format("[{0}]({1})", elementValue, elementURL);
                result.Append(currentAdd);
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            string html = Console.ReadLine();
            Console.WriteLine(ReplaceHTMLTags(html));
        }
    }
}
