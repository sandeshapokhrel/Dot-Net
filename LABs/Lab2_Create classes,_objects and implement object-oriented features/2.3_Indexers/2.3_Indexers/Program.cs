// Write a program to show the implementation of indexer in an appropriate class

using System;

class Student
{
    private string[] subjects = new string[5];

    // Indexer to access subjects by index
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= subjects.Length)
                throw new IndexOutOfRangeException("Index out of range.");
            return subjects[index];
        }
        set
        {
            if (index < 0 || index >= subjects.Length)
                throw new IndexOutOfRangeException("Index out of range.");
            subjects[index] = value;
        }
    }
} 

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student[0] = "Mathematics";
        student[1] = "Science";

        Console.WriteLine(student[0]); // Output: Mathematics
        Console.WriteLine(student[1]); // Output: Science
    }
}

