namespace Constructors
{
    using System;



    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber) // by using : base it means I dont have to create a field in Car for registrationNumber. It will set it in the Vehicle base class and can be used there.
        {
            
            Console.WriteLine($"Car is being Initialized. {registrationNumber}");
        }
    }
}

