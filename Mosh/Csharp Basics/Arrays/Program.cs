using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArraysAndLists();

        }
        private static void NonPrimitiveTypes()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            bool[] flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            string[] names = new string[3] { "Jack", "John", "Mary" };
            Console.WriteLine(names[0]);
        }

        private static void ArraysAndLists()
        {
            int[] numbers = { 3, 7, 9, 2, 14, 6 };
            
            //Length
            Console.WriteLine($"Length: {numbers.Length}");
            
            //IndexOf
            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine($"Index of 9 is: {index}");

            //Clear
            Array.Clear(numbers, 0, 2);// = 0,0,9,2,14,6
            Console.WriteLine("Effect of Clear()");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); 
            }

            //Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3); // = 0,0,9
            Console.WriteLine("Effect of Copy()");
            foreach (int number in another)
            {
                Console.WriteLine(number); 
            }

            //Sort
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            //Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }

    
}
