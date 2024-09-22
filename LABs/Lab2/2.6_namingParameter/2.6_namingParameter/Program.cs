// Create a method and implement it to show the use of named parameter. 
using System;

class Program
{
    static void Main()
    {44
        DisplayInfo(age: 13, name: "Sandesha");
    }

    static void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
