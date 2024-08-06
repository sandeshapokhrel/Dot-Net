//Write a program to evaluate GCD of two given integers. Use function that returns GCD. 
using System;

class Program
{
    static void Main()
    {
        int n1, n2;

        Console.Write("Enter two integers: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        int gcd = FindGCD(n1, n2);

        Console.WriteLine($"G.C.D of {n1} and {n2} is {gcd}");
    }

    static int FindGCD(int n1, int n2)
    {
        int gcd = 1;
        for (int i = 1; i <= n1 && i <= n2; ++i)
        {
            if (n1 % i == 0 && n2 % i == 0)
                gcd = i;
        }
        return gcd;
    }
}
