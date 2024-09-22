// Show the dynamic binding (polymorphism) through a clear program. 
using System;

class Animal
{
    // Virtual method to enable dynamic binding
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    // Overriding the base class method
    public override void Sound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : Animal
{
    // Overriding the base class method
    public override void Sound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Base class reference, derived class objects
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        // Dynamic binding at runtime
        myAnimal.Sound();  // Output: Animal makes a sound.
        myDog.Sound();     // Output: Dog barks.
        myCat.Sound();     // Output: Cat meows.
    }
}
