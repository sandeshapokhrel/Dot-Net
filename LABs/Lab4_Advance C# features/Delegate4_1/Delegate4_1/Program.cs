// Write a program to demonstrate the use of Delegate. 
using System;

namespace DelegatesEg4_1
{
    public delegate int MathOperation(int x, int y);

    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static void Main()
        {
            MathOperation operation = Add;

            int result = operation(5, 6);
            Console.WriteLine("Addition: " + result);

            operation = Mul;
            result = operation(5, 3);
            Console.WriteLine("Multiplication: " + result);
        }
    }
}
