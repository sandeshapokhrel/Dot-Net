using System;

class Student
{
    private string name;
    private string age;

    // Parameterized constructor
    public Student(string name, string age)
    {
        this.name = name;
        this.age = age;
    }

    // Method to get the student's name
    public string GetName()
    {
        return name;
    }

    // Method to get the student's age
    public string GetAge()
    {
        return age;
    }

    static void Main(string[] args)
    {
        // Create a new Student object with a string for age
        Student std = new Student("Sandesha", "20");

        // Print the student's name and age
        Console.WriteLine("Name = " + std.GetName());
        Console.WriteLine("Age = " + std.GetAge());
    }
}

//Above program have constructor which is a special method 
//Only one Destructor in one class 