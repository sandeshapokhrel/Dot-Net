//Write a program to identify whether the given number is a perfect number or not. [28 is a perfect number.] Write a program to identify whether the given number is a perfect number or not. [28 is a perfect number.] 
using System;
    class Program
{
     static void Main ()
    {
        int n, i, sum;
        Console.Write("Input the number:");
        n = int.Parse(Console.ReadLine());
        sum = 0;
        Console.Write("The positive divisors:");
        for (i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
                Console.Write(i + " ");
            }
        }
        Console.WriteLine(" The sum of divisior is:" + sum);
        if (sum == n)
        {
            Console.WriteLine(" It is a perfect number ");
        }
        else
        {
            Console.Write(" It is not a positive number ");
        }

    }
}