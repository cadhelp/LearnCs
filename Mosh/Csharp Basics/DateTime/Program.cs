

namespace DateTime
{
    using System;

    using DateTime = System.DateTime;

    internal class Program
    {
        static void Main(string[] args)
        {
            //DateAndTime();
            TimeSpans();

        }
        //DateTime and TimeSpan are immutable
        static void DateAndTime()
        {
            DateTime now = DateTime.Now;
            DateTime dateTime = new DateTime(2015, 1, 1);
            DateTime today = DateTime.Today;

            Console.WriteLine($"Hour: {now.Hour}");
            Console.WriteLine($"Minute: {now.Minute}");


            DateTime tomorrow = now.AddDays(1);
            DateTime yesterday = now.AddDays(-1);


            Console.WriteLine(now.ToLongDateString()); // Friday, June 24, 2022
            Console.WriteLine(now.ToShortDateString()); // 6/24/2022
            Console.WriteLine(now.ToLongTimeString()); // 10:00:15 PM
            Console.WriteLine(now.ToShortTimeString()); // 10:00 PM
            Console.WriteLine(now.ToString()); // 6/24/2022 10:00:15 PM
            Console.WriteLine(now.ToString("yy-MM-dd")); // 22-06-24
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));// 22-06-24 10:00
            // GOOGLE c# datetime format specifier    https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings


            Console.WriteLine($"Yesterday was {yesterday}, Today is {today}, Tomorrow is {tomorrow}");
        }

        static void TimeSpans()
        {
            //Creating TimeSpans
            TimeSpan timeSpan = new TimeSpan(1,2,3);
            TimeSpan timeSpan2 = new TimeSpan(1,0,0);
            TimeSpan timeSpan3 = TimeSpan.FromHours(1);

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);
            TimeSpan duration = end - start;

            Console.WriteLine($"Duration: {duration}");

            // Properties
            Console.WriteLine($"Minutes: {timeSpan.Minutes}"); // returns 2 from line 48
            Console.WriteLine($"Minutes Total: {timeSpan.TotalMinutes}"); // It adds all properties 1 hour + 2 minutes + 3 seconds and returns 62.05  from line 48 

            // Add and subtract returns a new timespan
            Console.WriteLine($"Add Example: {timeSpan.Add(TimeSpan.FromMinutes(8))}");
            Console.WriteLine($"Subtract Example: {timeSpan.Subtract(TimeSpan.FromMinutes(2))}");


            //ToString()
            Console.WriteLine($"ToString {timeSpan.ToString()}"); // by default cw already does this but others dont

            // Parse
            Console.WriteLine($"Parse: {TimeSpan.Parse("01:02:03")}");

        }
    }
}
