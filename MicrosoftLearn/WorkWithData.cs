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
}