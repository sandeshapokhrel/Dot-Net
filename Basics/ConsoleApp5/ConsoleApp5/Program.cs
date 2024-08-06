//Write a recursive program to find the sum of n natural numbers

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int sum = SumOfNaturalNumbers(n);
        Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
    }

    static int SumOfNaturalNumbers(int n)
    {
        if (n == 1) 
        {
            return 1;
        }
        else 
        {
            return n + SumOfNaturalNumbers(n - 1);
        }
    }
}
