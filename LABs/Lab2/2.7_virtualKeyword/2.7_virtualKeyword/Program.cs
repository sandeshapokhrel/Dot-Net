// Write a program to demonstrate the virtual method and its use. 
using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();

        myAnimal.MakeSound(); // Calls the method in Animal
        myDog.MakeSound();    // Calls the overridden method in Dog
    }
}
