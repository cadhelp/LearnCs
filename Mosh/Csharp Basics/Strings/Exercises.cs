using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Exercises
    {
       
        /// <summary>
        /// Checks the consecutive.
        /// 1- Write a program and ask the user to enter a few 
        /// numbers separated by a hyphen. Work out if the 
        /// numbers are consecutive. For example, if the input 
        /// is "5-6-7-8-9" or "20-19-18-17-16", display a 
        /// message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        public static void CheckConsecutive()
        {
            string promptResult = string.Empty;
            while (string.IsNullOrWhiteSpace(promptResult))
            {
                Console.WriteLine("Enter numbers separated by hyphens. (ie 4-5-6):");
                promptResult = Console.ReadLine();
            }

            string[] split = promptResult.Split('-');
            int startNum = int.MinValue;
            
            foreach (string s in split)
            {
                int i = Convert.ToInt32(s);

                if (startNum < i)
                {
                    startNum = i;
                    continue;
                }

                Console.WriteLine("Not Consecutive");
                return;
            }

            Console.WriteLine("Consecutive");

        }
        
        /// <summary>
        /// Checks the duplicates.
        /// 2- Write a program and ask the user to enter a few numbers 
        /// separated by a hyphen. If the user simply presses Enter, 
        /// without supplying an input, exit immediately; otherwise, 
        /// check to see if there are duplicates. If so, display 
        /// "Duplicate" on the console.
        /// </summary>
        public static void CheckDuplicates()
        {
            string promptResult = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter numbers separated by hyphens. ie(4-5-6):");
                Console.WriteLine("Type a number or press \"Enter\" to exit");
                promptResult = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(promptResult))
                {
                    return;
                }

                break;
            }

            List<string> split = promptResult.Split('-').ToList();
            for (int i = split.Count-1; i >= 0; i--)
            {
                string isContains = split[i];
                split.RemoveAt(i);
                if (split.Contains(isContains))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
            }
        }
       
        /// <summary>
        /// Checks the valid time.
        /// 3- Write a program and ask the user to enter a time value 
        /// in the 24-hour time format (e.g. 19:00). A valid time should 
        /// be between 00:00 and 23:59. If the time is valid, display "Ok"; 
        /// otherwise, display "Invalid Time". If the user doesn't provide 
        /// any values, consider it as invalid time.
        /// </summary>
        public static void CheckValidTime()
        {
            string promptResult = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter valid time in 24 hour format. ie 19:00:");
                Console.WriteLine("Enter a time or press \"Enter\" to exit");
                promptResult = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(promptResult))
                {
                    return;
                }

                break;
            }

            List<string> split = promptResult.Split(':').ToList();
            if (split.Count != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            int hour = split[0] == "00" ? 0 : Convert.ToInt32(split[0]);
            int minute = split[1] == "00" ? 0 : Convert.ToInt32(split[1]);

            if (hour >= 0 && hour <= 23)
            {
                if (minute >= 0 && minute <= 59)
                {
                    Console.WriteLine("Ok");
                    return;
                }
            }
            Console.WriteLine("Invalid Time");
        }

        /// <summary>
        /// Converts to pascalcase.
        /// 4- Write a program and ask the user to enter a few words 
        /// separated by a space. Use the words to create a variable 
        /// name with PascalCase. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make 
        /// sure that the program is not dependent on the input. 
        /// So, if the user types "NUMBER OF STUDENTS", the 
        /// program should still display "NumberOfStudents".
        /// </summary>
        public static void ToPascalCase()
        {
            Console.WriteLine("Enter a few words to convert to Pascal Case:");
            string promptResult = Console.ReadLine();
            string[] split = promptResult.Split(' ');
            StringBuilder returnString = new StringBuilder();
            foreach (string s in split)
            {
                for (int index = 0; index < s.Length; index++)
                {
                    char c;
                    if (index == 0)
                    {
                        c = s.ToUpper()[index];    
                    }
                    else
                    {
                        c = s.ToLower()[index];
                    }
                    
                    returnString.Append(c.ToString());
                }
            }

            Console.WriteLine(returnString);

        }

        
        /// <summary>
        /// Counts the vowels.
        /// 5- Write a program and ask the user to enter an 
        /// English word. Count the number of vowels (a, e, o, u, i) 
        /// in the word. So, if the user enters "inadequate", the 
        /// program should display 6 on the console.
        /// </summary>
        public static void CountVowels()
        {
            int returnCount = 0;
            Console.WriteLine("Enter a word to count the vowels:");
            string promptResult = Console.ReadLine();
            foreach (char s in promptResult.ToLower())
            {
                switch (s)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        returnCount ++;
                        break;
                }
            }
            
            Console.WriteLine(returnCount);
        }
    }
}
