// Demonstration the use of Enum. 

using System;

enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        // Using enum
        Days today = Days.Wednesday;

        Console.WriteLine($"Today is: {today}");
        Console.WriteLine($"Numeric value of {today} is: {(int)today}");

      
    }
}
