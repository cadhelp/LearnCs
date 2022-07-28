using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }

    internal class Notes
    {
        //Normally Enums are ints, but you can force to a byte like below
        //Its best practice to give values to your enums so they stay consistent. Could cause issues if you add more in the middle
        public enum ShippingMethodNote : byte
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3,
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingMethod method = ShippingMethod.Express;
            Console.WriteLine((int)method);//writes the int for the Express from the enum name

            int methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);// writes the enum Express from the int

            Console.WriteLine(method.ToString());//writes Express from the Enum
            Console.WriteLine(method);//cw always runs .ToString() on objects

            string methodName = "Express";
            ShippingMethod shippingMethod  = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName, true); // finds the enum from a string
            Console.WriteLine(shippingMethod);

        }
    }
}
