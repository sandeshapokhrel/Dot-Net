// Create an interface, implement in a class and demonstrate. 

using System;

public interface IAnimal
{
    void MakeSound();
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IAnimal myDog = new Dog(); // Interface reference
        myDog.MakeSound(); // Calls the method from Dog class
    }
}
