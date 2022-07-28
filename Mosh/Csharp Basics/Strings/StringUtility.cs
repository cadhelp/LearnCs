using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return text;
            }

            string[] words = text.Split(' ');
            int totalCharacters = 0;
            List<string> summaryWords = new List<string>();

            foreach (string word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return $"{string.Join(" ", summaryWords)} ...";
        }
    }
}
