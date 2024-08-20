using System;

abstract class Animal
{
    public abstract void MakeSound();

    // Regular method 
    public void DisplayHabitat(string habitat)
    {
        Console.WriteLine("Habitat: " + habitat);
    }
}

class Dog : Animal
{
    // implement the abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    // implement the abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myDog = new Dog();
        myDog.DisplayHabitat("House");  
        myDog.MakeSound();  

        Animal myCat = new Cat();
        myCat.DisplayHabitat("jungle");  
        myCat.MakeSound();  
    }
}