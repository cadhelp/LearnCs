using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    using Random = System.Random;

    internal class Exercises
    {

        /// <summary>
        /// Fulls the divisible by3.
        /// Exercise 1
        /// 1- Write a program to count how many numbers between
        /// 1 and 100 are divisible by 3 with no remainder.
        /// Display the count on the console.
        /// </summary>
        /// <returns>List&lt;System.String&gt;.</returns>
        public static List<string> FullDivisibleBy3()
        {
            List<string> result = new List<string>();

            const int MaxNumber = 100;

            for (int i = 1; i < MaxNumber; i++)
            {
                if (i % 3 == 0)
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }


        /// <summary>
        /// Asks for number.
        /// Exercise 2
        /// 2- Write a program and continuously ask the user to
        /// enter a number or "ok" to exit. Calculate the sum of
        /// all the previously entered numbers and display it on
        /// the console.
        /// </summary>
        public static string AskForNumber()
        {
            int total = 0;
            while (true)
            {
                Console.WriteLine("Type a number or \"Ok\" to exit");
                string promptResult = Console.ReadLine();
                if (promptResult == null) continue;
                if (promptResult.ToLower() == "ok")
                {
                    return $"The total is: {total}";
                }

                total += int.Parse(promptResult);

            }
        }

        //Exercise 3
        //3- Write a program and ask the user to enter a number.
        //Compute the factorial of the number and print it on
        //the console. For example, if the user enters 5, the
        //program should calculate 5 x 4 x 3 x 2 x 1 and display
        //it as 5! = 120.
        public static string ReturnFactorial()
        {
            Console.WriteLine("Enter a number to compute its factorial:");
            int factorialStart = int.Parse(Console.ReadLine());
            int factorialResult = factorialStart;
            for (int i = 1; i < factorialStart; i++)
            {
                factorialResult = factorialResult * i;
            }

            return $"{factorialStart}! = {factorialResult}";
        }

        //Exercise 4
        //4- Write a program that picks a random number between
        //1 and 10. Give the user 4 chances to guess the number.
        //If the user guesses the number, display “You won";
        //otherwise, display “You lost". (To make sure the
        //program is behaving correctly, you can display the
        //secret number on the console first.)
        public static string GuessInFour()
        {
            Random random = new Random();
            int randomResult = random.Next(1,10);

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Guess the number between 1-10:");
                int guessedRandom = int.Parse(Console.ReadLine());
                if (guessedRandom != randomResult)
                {
                    continue;
                }
                
                break;
            }

            return $"The number to guess was {randomResult}";

        }


        //Exercise 5
        //5- Write a program and ask the user to enter a series
        //of numbers separated by comma. Find the maximum of the
        //numbers and display it on the console. For example,
        //if the user enters “5, 3, 8, 1, 4", the program should
        //display 8.

        public static string ReturnMax()
        {
            int maxResult = -1;
            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                int promptResult = int.Parse(input);
                if (promptResult >= maxResult)
                {
                    maxResult = promptResult;
                }
                
            }

            return maxResult.ToString();
        }

        
    }
}
