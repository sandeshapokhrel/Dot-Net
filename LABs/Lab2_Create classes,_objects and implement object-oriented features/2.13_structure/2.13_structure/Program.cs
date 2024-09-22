// Create a fully featured structure (Struct) and show its implementation. 

using System;

struct Student
{
    public string Name;
    public int Age;
    public double GPA;

    // Constructor to initialize struct fields
    public Student(string name, int age, double gpa)
    {
        Name = name;
        Age = age;
        GPA = gpa;
    }

    // Method to display student info
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, GPA: {GPA}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Student struct object
        Student student1 = new Student("Sandesha", 13, 3.8);

        // Displaying the student info
        student1.DisplayInfo();
    }
}
