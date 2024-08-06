// Write a program to read the mark of a subject and print the equivalent grade.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the mark of the subject: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int mark))
        {
            string grade;

            if (mark >= 90 && mark <= 100)
            {
                grade = "A";
            }
            else if (mark >= 80 && mark < 90)
            {
                grade = "B";
            }
            else if (mark >= 70 && mark < 80)
            {
                grade = "C";
            }
            else if (mark >= 60 && mark < 70)
            {
                grade = "D";
            }
            else if (mark >= 0 && mark < 60)
            {
                grade = "F";
            }
            else
            {
                Console.WriteLine("Invalid mark. Please enter a mark between 0 and 100.");
                return;
            }

            Console.WriteLine($"The grade is: {grade}");
        }
        else
        {
            Console.WriteLine($"The input is invalid, enter the valid details");
        }
    }
}
