// Write a C# program to store N numbers in a one-dimensional array and calculate its average with the help of method. 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("The number of elements must be a positive integer.");
            return;
        }

        int[] numbers = new int[n];

        // Input numbers
        Console.WriteLine($"Enter {n} numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Calculate average
        double average = CalculateAverage(numbers);
        Console.WriteLine($"The average of the entered numbers is: {average}");
    }

    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 0; // To handle the case when array is empty
        }

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return (double)sum / numbers.Length;
    }
}
