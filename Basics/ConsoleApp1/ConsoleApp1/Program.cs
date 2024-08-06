//Write a program to convert centigrade to Fahrenheit. [F = 9/5 * C + 32] (Do not change the expression)

using System;

class Program
{
    static void Main()
    {

        double celsius = 5;

        double fahrenheit = (double)9 / 5 * celsius + 32;

        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }
}
