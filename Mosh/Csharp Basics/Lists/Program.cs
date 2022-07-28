using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new[]{5,6,7});

            foreach (int number in numbers)
            {
                Console.WriteLine($"{number}");    
            }

            Console.WriteLine();
            Console.WriteLine($"Index of 1: {numbers.IndexOf(1)}");
            Console.WriteLine($"Last Index of 1: {numbers.LastIndexOf(1)}");

            Console.WriteLine($"Count: {numbers.Count}");

            //This removes only the first instance of 1 from the list
            //numbers.Remove(1);
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine($"{number}");    
            //}

            //This removes all instances of 1 from the list
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (int number in numbers)
            {
                Console.WriteLine($"{number}");    
            }


            numbers.Clear();
            Console.WriteLine($"Count after we cleared the list: {numbers.Count}");

            Exercises.FbLikes();
            Exercises.ReverseName();
            Exercises.EnterFiveNumbers();
            Exercises.EnterManyNumbers();
            Exercises.SmallestThreeOfFive();

        }
    }
}
