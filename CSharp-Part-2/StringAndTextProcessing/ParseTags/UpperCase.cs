using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static string ToUpperCase(string text)
        {
            StringBuilder newText = new StringBuilder();
            newText.Append(text);
            int index = -1, index2 = -1;

            while (true)
            {
                index = text.IndexOf("<upcase>");
                index2 = text.IndexOf("</upcase>");

                if (index == -1 || index2 == -1)
                {
                    break;
                }

                int startIndex = index + 8;               

                int chunkLength = index2 - startIndex;

                string textChunk = text.Substring(startIndex, chunkLength);
                textChunk = textChunk.ToUpper();
                newText.Remove(index, chunkLength + 17);
                newText.Insert(index, textChunk, 1);
                text = newText.ToString();
            }
            return text;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ToUpperCase(input));
        }
    }
}
