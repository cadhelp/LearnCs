using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;



            Console.WriteLine(a + b);
            Console.WriteLine( a / b);
            Console.WriteLine((float) a / b);
            Console.WriteLine( a % b);

            var a1 = 1;
            var b1 = 2;
            var c1 = 3;
            Console.WriteLine(a1 + b1 * c1);
            Console.WriteLine((a1 + b1) * c1);


            Console.WriteLine(a1 > b1);
            Console.WriteLine(a1 == b1);
            Console.WriteLine(a1 != b1);
            Console.WriteLine(!(a1 != b1));

            Console.WriteLine(c1 > b1 && c1 > a1);
            Console.WriteLine(c1 > b1 && c1 == a1);
            Console.WriteLine(c1 > b1 || c1 == a1);
            Console.WriteLine(!(c1 > b1 || c1 == a1));

            // Here is a comment
            /*
               Here is a multi-line comment
                Comments are to explain Whys, Hows, Constraints, etc. Not the Whats the code doing.
            */


        }
    }
}
