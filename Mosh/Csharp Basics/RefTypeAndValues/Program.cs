using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeAndValues
{
    public class Person
    {
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0} b: {1}",a,b));

            //Stack
            //    a = 10
            //    b = 10

            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0} array2[0]: {1}",array1[0],array2[0]));

                //Stack                     Heap
                //                              0x00416A = 1,2,3
                //array1 = 0x00416A             
                //array2 = 0x00416A
                //

                int number = 1;
                Increment(number);
                Console.WriteLine(number);// stayed 1

                Person person = new Person() { Age = 20 };
                MakeOld(person);
                Console.WriteLine(person.Age);//changed to 30
        }


        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
