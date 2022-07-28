using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    using Random = System.Random;

    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());    
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1,10));    
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());    
            }

            //10 char password
            for (int i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97,122));    // lowercase letters
            }
            Console.WriteLine(); 
            //better 10 char password
            for (int i = 0; i < 10; i++)
            {
                Console.Write((char)('a' + random.Next(0,26)));    // lowercase letters thats a bit more intuitive
            }
            Console.WriteLine();

            char[] buffer = new char[10];

            //betterer 10 char password
            for (int i = 0; i < 10; i++)
            {
                buffer[i]=(char)('a' + random.Next(0,26));    // lowercase letters thats a bit more intuitive
            }
            string password = new string(buffer);
            Console.WriteLine(password); 

            //bettererer 10 char password
            const int PasswordLength = 10;
            char[] buffer2 = new char[PasswordLength];
            for (int i = 0; i < PasswordLength ; i++)
            {
                buffer2[i]=(char)('a' + random.Next(0,26));    // lowercase letters thats a bit more intuitive
            }
            string password2 = new string(buffer2);
            Console.WriteLine(password2); 


            //Exercise 1
            Console.WriteLine($"There are {Exercises.FullDivisibleBy3().Count} numbers fully divisible by three between 1-100.");

            //Exercise 2
            string resultsAskForNumber = Exercises.AskForNumber();
            Console.WriteLine(resultsAskForNumber);

            //Exercise 3
            string resultReturnFactorial = Exercises.ReturnFactorial();
            Console.WriteLine(resultReturnFactorial);

            //Exercise 4
            string resultGuessInFour = Exercises.GuessInFour();
            Console.WriteLine(resultGuessInFour);

            //Exercise 4
            string resultReturnMax = Exercises.ReturnMax();
            Console.WriteLine(resultReturnMax);
        }


    }
}
