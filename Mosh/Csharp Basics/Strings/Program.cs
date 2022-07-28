using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NonPrimitiveTypes()
            //WorkingWithText();
            //SummarizingText();
            //StringBuildDemo();
            //Exercises.CheckConsecutive();
            //Exercises.CheckDuplicates();
            //Exercises.CheckValidTime();
            //Exercises.ToPascalCase();
            Exercises.CountVowels();

        }

        private static void NonPrimitiveTypes()
        {
            /*Escape Characters
               \n      New line
               \t      Tab
               \\      Backslash
               \'      Single Quotation Mark
               \"      Double Quotation Mark
            */

            string path = "c:\\projects\\project1\\folder1";
            string verbatimString = @"c:\projects\project1\folder1";

            string firstName = "Mosh";
            string lastName = "Hamedani";

            string fullName = firstName + " " + lastName;
            string hisFullName = string.Format("His name is {0} {1}", firstName, lastName);

            string[] names = new string[3] { "John", "Jack", "Mary" };
            string formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            string text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            string verbatim = @"Hi John 
                                Look into the following paths
                                c:\folder1\folder2
                                c:\folder3\folder4";
        }


        private static void WorkingWithText()
        {
            //Converting Numbers to String with Formatters
            int i = 1234;
            string text = i.ToString(); // "1234"
            string currency = i.ToString("C"); // "$1,234.00"
            string currencyNoDecimal = i.ToString("C0"); // "$1,234"
            /* Common Format Strings
                c or C = Currency
                d or D = Decimal
                e or E = Exponential
                f or F = Fixed Point
                x or X = Hexadecimal
             */


            string fullName = "Mosh Hamedani ";
            Console.WriteLine($"Trim: '{fullName.Trim()}'");
            Console.WriteLine($"ToUpper: '{fullName.Trim().ToUpper()}'");
            Console.WriteLine($"ToLower: '{fullName.Trim().ToLower()}'");

            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);
            Console.WriteLine($"FirstName: {firstName}");
            Console.WriteLine($"LastName: {lastName}");

            string[] names = fullName.Split(' ');
            Console.WriteLine($"FirstName: {names[0]}");
            Console.WriteLine($"LastName: {names[1]}");

            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh"));

            //IsNullOrWhiteSpace will check all of these scenarios and is better than IsNullOrEmpty
            string cc = null;
            cc = "";
            cc = " ";
            if (string.IsNullOrWhiteSpace(cc))
            {
                Console.WriteLine("Invalid");
            }

            string str = "25";
            Byte age = Convert.ToByte(str);

            float price = 29.95f;

            Console.WriteLine(price.ToString());// 29.95
            Console.WriteLine(price.ToString("C"));// $29.95
            Console.WriteLine(price.ToString("C0"));// $30

        }

        private static void SummarizingText()
        {
            string sentence = "This is going to be a really really really really really really long text.";
            Console.WriteLine(StringUtility.SummerizeText(sentence, 25));

        }

        private static void StringBuildDemo()
        {
            StringBuilder stringBuilder = new StringBuilder("Hello World");
            stringBuilder.Append('-', 10).
                AppendLine().
                Append("Header").
                AppendLine().
                Append('-', 10);

            // You can chain them like above or leave them like below.
            // Above is easier to read.
            stringBuilder.Replace('-','+');

            stringBuilder.Remove(0, 10);

            stringBuilder.Insert(0, new string('-', 10));

            Console.WriteLine(stringBuilder);

            Console.WriteLine($"First Character: {stringBuilder[0]}");


        }

    }
}
