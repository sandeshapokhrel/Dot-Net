// Write a C# program for matrix addition with the help of function add (int [,] a, int [,] b).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        // Initialize matrices
        int[,] matrixA = new int[rows, cols];
        int[,] matrixB = new int[rows, cols];

        // Input for matrix A
        Console.WriteLine("Enter elements for matrix A:");
        ReadMatrix(matrixA, rows, cols);

        // Input for matrix B
        Console.WriteLine("Enter elements for matrix B:");
        ReadMatrix(matrixB, rows, cols);

        // Add matrices
        int[,] resultMatrix = Add(matrixA, matrixB);

        // Display the result
        Console.WriteLine("Result of matrix addition:");
        PrintMatrix(resultMatrix);
    }

    static void ReadMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[,] Add(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
