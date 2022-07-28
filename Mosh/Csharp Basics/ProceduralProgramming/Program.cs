using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine($"Your reversed name is: {ReverseName(name)}");






            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Type a number or \"Quit\" to exit");
                string promptResult = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(promptResult)) continue;
                if (promptResult.ToLower() == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(promptResult));
            }

            Console.WriteLine($"Your unique numbers are: {GetUniqueNumbers(numbers)}");

        }

        private static string GetUniqueNumbers(List<int> numbers, bool sorted = false)
        {
            if (sorted) numbers.Sort();
            List<int> uniqueNumbers = new List<int>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (!uniqueNumbers.Contains(numbers[i]))
                {
                    uniqueNumbers.Add(numbers[i]);
                }
                numbers.RemoveAt(i);
            }

            uniqueNumbers.Reverse();
            return string.Join(",", uniqueNumbers);
        }

        public static string ReverseName(string name)
        {
            char[] nameArray = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                nameArray[name.Length - i] = name[i - 1];
            }

            return new string(nameArray);
        }





    }
}
