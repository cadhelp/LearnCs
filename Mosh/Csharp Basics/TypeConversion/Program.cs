using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;

            Console.WriteLine(i);

            int i2 = 1;
            byte b2 = (byte)i2;
            Console.WriteLine(b2);

            int i3 = 1000;
            byte b3 = (byte)i3;
            Console.WriteLine(b3);

            string number = "1234";
            int i4 = Convert.ToInt32(number);
            Console.WriteLine(i4);

            try
            {
                string number2 = "1234";
                byte b4 = Convert.ToByte(number2);
                Console.WriteLine(b4);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                string str = "true";
                bool b5 = Convert.ToBoolean(str);
                Console.WriteLine(b5);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }
    }
}
