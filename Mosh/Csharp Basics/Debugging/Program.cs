using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        /*
        F5                  = Debug mode
        Ctrl + F5           = Run without Debug
        Shift + F5          = Stop Debug mode
        Ctrl + Shift + F5   = Restart Application
        F9                  = Set/Remove break point
        */

        /*
        In the CallStack the top line is where you are at and the bottom line is where you started
        You can double click the line in the callstack and it will take you to that line in the code.
         */
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> smallests = GetSmallests(numbers, 3);

            foreach (int number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null) // added to ensure our list is not null.
            {
                throw new ArgumentNullException("list");
            }
            if (count > list.Count || count <= 0) // added to ensure we have a list and count that work
            {
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");
            }

            // Remove side effects
            List<int> buffer = new List<int>(list); // added for side effect
            List<int> smallests = new List<int>();

            while (smallests.Count < count)
            {
                int min = GetSmallest(buffer); // added for side effect Changed from list to bugger
                smallests.Add(min);
                buffer.Remove(min); // added for side effect Changed from list to bugger
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
         // Could check if list is empty and return a number, but not sure what number to return
         // Could check if list is empty and throw an error
         //Instead we are throwing an error in calling method since it cant continue
            int min = list[0]; // Assume the first number is the smallest
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min) // reversed from > to <
                    min = list[i];
            }
            return min;
        }
    }
}
