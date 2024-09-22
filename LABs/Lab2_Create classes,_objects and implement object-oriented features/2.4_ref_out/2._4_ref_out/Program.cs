﻿// Write a program in which the out and reference variables are being used. 
using System;

class program
{
    static void sum(int x, int y, out int z)
    {
        z = x + y;
    }
    static void increment(ref int i)
    {
        i++;
    }
    static void Main(string[] args)
    {
        int result = 0;
        sum(1, 2, out result);
        Console.WriteLine(result);

        int i = 3;
        increment(ref i);
        Console.WriteLine(i);
    }
}