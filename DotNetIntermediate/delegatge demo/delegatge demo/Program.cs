using System;

public class Program
{
    // Step 1: Declare a delegate that takes two integers and returns an integer
    public delegate int MathOperation(int x, int y);

    // Step 2: Define methods that match the delegate signature
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static void Main()
    {
        // Step 3: Instantiate the delegate and assign it the Add method
        MathOperation operation = Add;

        // Step 4: Call the delegate with arguments for addition
        int result = operation(5, 3);
        Console.WriteLine("Addition: " + result);  // Output: Addition: 8

        // Step 5: Reassign the delegate to the Multiply method
        operation = Multiply;

        // Step 6: Call the delegate with arguments for multiplication
        result = operation(5, 3);
        Console.WriteLine("Multiplication: " + result);  // Output: Multiplication: 15
    }
}
