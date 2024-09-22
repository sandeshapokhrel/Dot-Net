// Write a program that shows the overloading of method and operators (binary and unary).

    using System;

class Calculator
{
    // Method Overloading
    public int Add(int a, int b)  // Two integer parameters
    {
        return a + b;
    }

    public double Add(double a, double b)  // Two double parameters
    {
        return a + b;
    }

    // Operator Overloading (Binary +)
    public static Calculator operator +(Calculator c1, Calculator c2)
    {
        Calculator result = new Calculator();
        return result;
    }

    // Operator Overloading (Unary ++)
    public static Calculator operator ++(Calculator c)
    {
        return c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Method Overloading example
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(3, 5)); // Calls int Add
        Console.WriteLine(calc.Add(2.5, 4.5)); // Calls double Add

        // Operator Overloading example
        Calculator c1 = new Calculator();
        Calculator c2 = new Calculator();
        Calculator result = c1 + c2;  // Using overloaded binary +
        result++;  // Using overloaded unary ++

        Console.WriteLine("Overloading operators executed.");
    }
}
