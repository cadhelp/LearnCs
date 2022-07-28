using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseSwitchCase
{
    public enum PictureOrientation
    {
        Portrait,
        Landscape
    }
    internal class Exercise
    {
        /// <summary>
        /// Validates the number one to ten.
        /// 1- Write a program and ask the user to enter a number.
        /// The number should be between 1 to 10. If the user enters
        /// a valid number, display "Valid" on the console.
        /// Otherwise, display "Invalid". (This logic is used a
        /// lot in applications where values entered into input
        /// boxes need to be validated.)
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>System.String.</returns>
        public static string ValidateNumberOneToTen(int number)
        {
            return (number >= 1 && number <= 10) ? "Valid" : "Invalid";
        }

        /// <summary>
        /// Gets the maximum from two.
        /// 2- Write a program which takes two numbers from the
        /// console and displays the maximum of the two.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public static int GetMaxFromTwo()
        {
            Console.WriteLine("Enter a number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            return (numberOne > numberTwo)?numberOne : numberTwo;
        }

        /// <summary>
        /// Gets the portrait orientation.
        /// 3- Write a program and ask the user to enter
        /// the width and height of an image. Then tell if the
        /// image is landscape or portrait.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GetPortraitOrientation()
        {
            Console.WriteLine("Enter the height: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            int width = int.Parse(Console.ReadLine());
            return (height > width) ? PictureOrientation.Portrait.ToString() : PictureOrientation.Landscape.ToString();
        }


        /// <summary>
        /// Checks the speed.
        /// 4- Your job is to write a program for a speed camera.
        /// For simplicity, ignore the details such as camera,
        /// sensors, etc and focus purely on the logic. Write a
        /// program that asks the user to enter the speed limit.
        /// Once set, the program asks for the speed of a car.
        /// If the user enters a value less than the speed limit,
        /// program should display Ok on the console. If the value
        /// is above the speed limit, the program should calculate
        /// the number of demerit points. For every 5km/hr above
        /// the speed limit, 1 demerit points should be incurred
        /// and displayed on the console. If the number of
        /// demerit points is above 12, the program should
        /// display License Suspended.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string CheckSpeed()
        {
            Console.WriteLine("Enter the speed limit: ");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the carSpeed: ");
            int carsSpeed = int.Parse(Console.ReadLine());

            if (carsSpeed < speedLimit)
            {
                return "Ok";
            }

            int aboveSpeed = carsSpeed - speedLimit;
            int points = aboveSpeed / 5;
            return points <= 12 ? $"Points against license: {points.ToString()}" : "License Suspended";
        }

    }
}
