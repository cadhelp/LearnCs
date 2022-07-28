namespace Classes
{
    using System;

    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Indroduce()
        {
            Console.WriteLine($"My name is {this.FirstName} {this.LastName}.");
        }
    }
}