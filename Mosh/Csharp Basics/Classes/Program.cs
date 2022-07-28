using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    using System;

    using Classes.Math;

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "matt";
            person.LastName = "Smith";
            person.Indroduce();


            Calculator calculator = new Calculator();
            int added = calculator.Add(1, 2);
            Console.WriteLine(added);
        }
    }

    
}
