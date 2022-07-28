namespace Constructors
{
    using System;

    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being Initialized.");
        //}

        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;
            Console.WriteLine($"Vehicle is being Initialized. {registrationNumber}");
        }

    }
}