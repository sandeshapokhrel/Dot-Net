// Write a program to arrange the numbers (in array) in ascending order using bubble sort. 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        // Input array elements
        Console.WriteLine($"Enter {n} numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Sort the array using bubble sort
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;

             
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // Swap numbers[j] and numbers[j + 1]
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;

                    swapped = true;
                }
            }

            // If no two elements were swapped in the inner loop, then the array is sorted
            if (!swapped)
                break;
        }

        // Display the sorted array
        Console.WriteLine("Array sorted in ascending order:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}

