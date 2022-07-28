using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Exercises
    {
        /// <summary>
        /// Fbs the likes.
        /// 1- When you post a message on Facebook, depending on the
        /// number of people who like your post, Facebook displays
        /// different information.
        /// If no one likes your post, it doesn't display anything.
        /// If only one person likes your post, it displays: [Friend's Name] likes your post.
        /// If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        /// If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
        /// Write a program and continuously ask the user to enter
        /// different names, until the user presses Enter (without
        /// supplying a name). Depending on the number of names provided,
        /// display a message based on the above pattern.
        /// </summary>
        public static void FbLikes()
        {
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Type a name or \"Enter\" to exit");
                string promptResult = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(promptResult))
                {
                    break;
                }

                names.Add(promptResult);
            }

            if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]}, {names.Count - 2} others like your post.");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post.");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post.");
            }
        }

        /// <summary>
        /// Reverses the name.
        /// 2- Write a program and ask the user to enter their name.
        /// Use an array to reverse the name and then store the
        /// result in a new string. Display the reversed name on the console.
        /// </summary>
        public static void ReverseName()
        {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            char[] nameArray = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                nameArray[name.Length - i] = name[i - 1];
            }

            string reversedName = new string(nameArray);
            Console.WriteLine($"Your reversed name is: {reversedName}");

        }

        /// <summary>
        /// Enters the five numbers.
        /// 3- Write a program and ask the user to enter 5 numbers.
        /// If a number has been previously entered, display an error
        /// message and ask the user to re-try. Once the user
        /// successfully enters 5 unique numbers, sort them
        /// and display the result on the console.
        /// </summary>
        public static void EnterFiveNumbers()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("You must type 5 unique numbers.");
            while (numbers.Count < 5)
            {
                Console.WriteLine("Type a unique number or \"Enter\" to exit");
                string promptResult = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(promptResult))
                {
                    Console.WriteLine($"You must enter at least 5 numbers. Please enter {5 - numbers.Count} more:");
                    continue;
                }
                int newNumber = Convert.ToInt32(promptResult);
                if (numbers.Contains(newNumber))
                {
                    Console.WriteLine("That number has already been entered. Please try again:");
                    continue;
                }
                numbers.Add(newNumber);
            }

            numbers.Sort();
            string sortedNumbers = string.Join(",", numbers);
            Console.WriteLine($"Your sorted numbers are: {sortedNumbers}");
        }



        /// <summary>
        /// Enters the many numbers.
        /// 4- Write a program and ask the user to continuously
        /// enter a number or type "Quit" to exit. The list of
        /// numbers may include duplicates. Display the unique
        /// numbers that the user has entered.
        /// </summary>
        public static void EnterManyNumbers()
        {
            List<int> numbers = new List<int>();
            string uniqueNumbers = string.Empty;
            while (true)
            {
                Console.WriteLine("Type a number or \"Quit\" to exit");
                string promptResult = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(promptResult)) continue;
                if (promptResult.ToLower() == "quit")
                {
                    Console.WriteLine($"Your unique numbers are: {uniqueNumbers}");
                    break;
                }
                int newNumber = Convert.ToInt32(promptResult);
                if (numbers.Contains(newNumber))
                {
                    continue;
                }

                numbers.Add(newNumber);
                uniqueNumbers = string.Join(",", numbers);
            }
        }


        /// <summary>
        /// Smallests the three of five.
        /// 5- Write a program and ask the user to supply a
        /// list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        /// If the list is empty or includes less than 5
        /// numbers, display "Invalid List" and ask the user
        /// to re-try; otherwise, display the 3 smallest numbers
        /// in the list.
        /// </summary>
        public static void SmallestThreeOfFive()
        {
            Console.WriteLine("You must type comma separated list of numbers.");
            Console.WriteLine("there must be a minimum of FIVE numbers.");
            string[] splitResult;
            while (true)
            {
                Console.WriteLine("Type your list of numbers or \"Enter\" to exit");
                string promptResult = Console.ReadLine();
                splitResult = promptResult.Split(',');
                if (string.IsNullOrWhiteSpace(promptResult) || splitResult.Length < 5)
                {
                    Console.WriteLine($"You must enter at least 5 numbers. Please enter {5 - splitResult.Length} more:");
                    continue;
                }

                break;
            }

            // Sorting the string causes it to sort 1, 10, 2.... Not good
            //Array.Sort(splitResult); 
            //Console.WriteLine($"Your three smallest numbers are: {splitResult[0]}, {splitResult[1]}, {splitResult[2]}");

            List<int> numbers = new List<int>();
            foreach (string s in splitResult)
            {
                numbers.Add(Convert.ToInt32(s));
            }

            numbers.Sort();
            Console.WriteLine($"Your three smallest numbers are: {numbers[0]}, {numbers[1]}, {numbers[2]}");
        }
    }
}
