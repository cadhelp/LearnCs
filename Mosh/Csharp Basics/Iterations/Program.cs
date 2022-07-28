using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****                   For Loops
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"For: {i}");
                }
            }


            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"For Reverse: {i}");
                }
            }

            //*****                   Foreach Loops
            string name = "John Smith";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"For {name[i]}");
            }

            foreach (char c in name)
            {
                Console.WriteLine($"Foreach {c}");
            }

            
            int[] numbers = new int[] { 1, 2, 3, 4 };
            foreach (int number in numbers)
            {
                Console.WriteLine($"Foreach {number}");
            }

            //*****                   While Loops
            int  counter = 0;
            while (counter  <=10)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine($"While {counter}");
                }

                counter++;  
            }

            while (true)
            {
                Console.Write("Type your name: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine($"@Echo: {input}");
            }

            while (true)
            {
                Console.Write("Type your name: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"@Echo: {input}");
                    continue;
                }

                break;
            }

        }
    }
}
