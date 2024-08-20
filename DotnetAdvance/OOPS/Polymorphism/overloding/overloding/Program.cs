using System;

class Calculator
{
   
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

  
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

    
        Console.WriteLine("Sum of 5 and 10: " + calc.Add(5, 10));  

     
        Console.WriteLine("Sum of 1, 2, and 3: " + calc.Add(1, 2, 3));  

     
        Console.WriteLine("Sum of 1.5 and 2.5: " + calc.Add(1.5, 2.5));  
    }
}
