// See https://aka.ms/new-console-template for more information

namespace MicrosoftLearn;

using System;
using System.Collections.Generic;
using System.Linq;

public class WorkWithData
{

    public static void Main()
    {
        FormatAlphaNumeric messageProduct = new FormatAlphaNumeric();
        
        Console.WriteLine($"Dear {messageProduct.CustomerName},");

        Console.WriteLine($"As a customer of our {messageProduct.CurrentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

        Console.WriteLine($"Currently, you own {messageProduct.CurrentShares:N} shares at a return of {messageProduct.CurrentReturn:P}.\n");

        Console.WriteLine($"Our new product, {messageProduct.NewProduct} offers a return of {messageProduct.NewReturn:P}.  Given your current volume, your potential profit would be {messageProduct.NewProfit:C}.\n");

        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "";

        comparisonMessage = messageProduct.CurrentProduct.PadRight(20);

        //NOTE or use Composite Formatting.comparisonMessage += String.Format("{0:P}", messageProduct.CurrentReturn).PadRight(10);
        comparisonMessage += $"{messageProduct.CurrentReturn:P}".PadRight(10);

        comparisonMessage += $"{messageProduct.CurrentProfit:C}".PadRight(20);

        comparisonMessage += "\n";

        comparisonMessage += messageProduct.NewProduct.PadRight(20);

        comparisonMessage += $"{messageProduct.NewReturn:P}".PadRight(10);

        comparisonMessage += $"{messageProduct.NewProfit:C}".PadRight(20);

        Console.WriteLine(comparisonMessage);
    }

    public class FormatAlphaNumeric
    {
        public string CustomerName { get; set; } = "Mr. Jones";

        public string CurrentProduct { get; set;} = "Magic Yield";

        public int CurrentShares { get; set;} = 2975000;

        public decimal CurrentReturn { get;set; } = 0.1275m;

        public decimal CurrentProfit { get; set;} = 55000000.0m;

        public string NewProduct { get; set;} = "Glorious Future";

        public decimal NewReturn { get;set; } = 0.13125m;

        public decimal NewProfit { get;set; } = 63000000.0m;
    }

    public class GetTextInBrackets
    {
        internal string GetTextBetweenFirstParenSet(string input)
        {
            // string input = "Find what is (inside the parentheses)";

            int openingPosition = input.IndexOf('(');
            int closingPosition = input.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);
            openingPosition++;
            int length = closingPosition - openingPosition;
            Console.WriteLine(input.Substring(openingPosition, length));
            return input.Substring(openingPosition, length);
        }

        internal string GetTextBetweenLastParenSet(string input)
        {
            //string input = "(What if) I am (only interested) in the last (set of parentheses)?";
            int openingPosition = input.LastIndexOf('(');

            openingPosition += 1;
            int closingPosition = input.LastIndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(input.Substring(openingPosition, length));
            return input.Substring(openingPosition, length);
        }
        
        internal List<string> GetTextBetweenAllParenSets(string input)
        {
            List<string> result = new List<string>();
            string message = "(What if) there are (more than) one (set of parentheses)?";
            while (true)
            {
                int openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;

                openingPosition += 1;
                int closingPosition = message.IndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));
                result.Add(message);

                // Note how we use the overload of Substring to return only the remaining 
                // unprocessed message:
                message = message.Substring(closingPosition + 1);
                
            }

            return result;
        }

        internal string GetTextBetweenSpans(string input)
        {
            // string input = "What is the value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int openingPosition = input.IndexOf(openSpan);
            int closingPosition = input.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            int length = closingPosition - openingPosition;
            Console.WriteLine(input.Substring(openingPosition, length));
            return input.Substring(openingPosition, length);
        }

        

        internal List<string> GetTextBetweenAllBracketTypes(string input)
        {
            List<string> result = new List<string>();
            string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // The IndexOfAny() helper method requires a char array of characters. 
            // We want to look for:

            char[] openSymbols = { '[', '{', '(' };

            // We'll use a slightly different technique for iterating through the 
            // characters in the string. This time, we'll use the closing position
            // of the previous iteration as the starting index for the next open
            // symbol. So, we need to initialize the closingPosition variable
            // to zero:

            int closingPosition = 0;

            while (true)
            {
                int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1) break;

                string currentSymbol = message.Substring(openingPosition, 1);

                // Now we must find the matching closing symbol
                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // To find the closingPosition, we use an overload of the IndexOf method to specify 
                // that our search for the matchingSymbol should start at the openingPosition in the string. 
    
                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                // Finally, use the techniques we've already learned to display the sub-string:

                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));
                result.Add(message.Substring(openingPosition, length));
            }
            return result;
        }

    }
}