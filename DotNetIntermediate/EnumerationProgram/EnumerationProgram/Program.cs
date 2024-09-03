// create a enumeration take a value from a user after the value is given and suggest the to do task acccording to the day. 

using System;
using static EnumerationProgram.Program;

namespace EnumerationProgram
{
    internal class Program
    {
        public enum WeekDays
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday

        }
    }
}
    internal class programMain
     { 
              static void Main(string[] args)
              {
        Console.WriteLine("Enter a number from (1-7) to find the day of the week and task to that particular Week");
        //reading input converting string to int since console.readline always return string
        int input = Convert.ToInt32(Console.ReadLine());
        if (input > 7 || input < 1)
        {
            Console.WriteLine("Enter the valid input");


        }
        else
        {

            WeekDays select = (WeekDays)input;


            switch (select)
            {
                case WeekDays.Sunday:
                    Console.WriteLine("its sunday,First Day of the week");
                    break;

                case WeekDays.Monday:
                    Console.WriteLine("its monday,Second Day of the week");
                    break;

                case WeekDays.Tuesday:
                    Console.WriteLine("its tuesday ");
                    break;

                case WeekDays.Wednesday:
                    Console.WriteLine("its Wednesday stay motivated ");
                    break;

                case WeekDays.Thursday:
                    Console.WriteLine("its Thusday, take a chill pill ");
                    break;

                case WeekDays.Friday:
                    Console.WriteLine("its friday Wrap Up your work and prepare for weekend");
                    break;
                case WeekDays.Saturday:
                    Console.WriteLine("Finally weekend, Enjoyyyyy");
                    break;


            }
      }
        Console.ReadKey();

    }
}
