// Write a C# program to initialize and display jagged array elements with sum of each row.
using System;
class Program
{
    public static void Main(string[] args)
    {
        int[][] jaggedarray = new int[3][];

        jaggedarray[0]=new int[]{ 1, 2, 3, 4 };
        jaggedarray[1]=new int[]{ 2, 4, 6 };
        jaggedarray[2]=new int[]{ 3,5 };
       
       for (int i=0; i < jaggedarray.Length; i++)
       {
                int rowsum = 0;
                Console.Write("row"+(i+1) +":");
              for (int j=0; j < jaggedarray[i].Length; j++)
              {
                   Console.Write(jaggedarray[i][j] + " ");
                   rowsum += jaggedarray[i][j];
              }
            Console.WriteLine("Sum of row is:" + rowsum);
        }
    
    }
}