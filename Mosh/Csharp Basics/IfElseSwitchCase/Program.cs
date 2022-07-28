using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");

            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine(" It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }


            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            // could also write the above like this
            price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            Season season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer :
                    Console.WriteLine("It's perfect to go to the beach.");
                    break;
                    case Season.Spring:
                        case Season.Winter:
                        Console.WriteLine("We've got a promotion");
                        break;
                default:
                    Console.WriteLine("I don't understand taht season!");
                    break;
            }

            //Exercise One
            //1- Write a program and ask the user to enter a number.
            //The number should be between 1 to 10. If the user enters a valid number,
            //display "Valid" on the console. Otherwise, display "Invalid".
            //(This logic is used a lot in applications where values entered into input boxes need to be validated.)

            int numberToValidate = 12;
            string validatedNumber = Exercise.ValidateNumberOneToTen(numberToValidate);
            Console.WriteLine($"Number to validate: {numberToValidate} is {validatedNumber}");

            //Exercise Two
            //2- Write a program which takes two numbers from the console and displays the maximum of the two.
            int largestNumber = Exercise.GetMaxFromTwo();
            Console.WriteLine($"{largestNumber} was the largest number.");

            //Exercise Three
            //3- Write a program and ask the user to enter the width and height of an image.
            //Then tell if the image is landscape or portrait.
            string portraitOrientation = Exercise.GetPortraitOrientation();
            Console.WriteLine($"The picture is {portraitOrientation}");

            //Exercise Four
            string speedReults = Exercise.CheckSpeed();
            Console.WriteLine($"The results of the speed camera are: {speedReults}");

        }
    }
}
