using System;

public class Person
{
    private string name; 

    public void SetName(string newName) 
    {
        name = newName;
    }

    public string GetName()  
    {
        return name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        // Set the name using the public method
        person.SetName("Ram");

  
        Console.WriteLine("Name: " + person.GetName());
    }
}
