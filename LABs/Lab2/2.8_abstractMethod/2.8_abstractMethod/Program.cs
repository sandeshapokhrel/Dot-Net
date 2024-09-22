// Create an abstract method and show its implementation also show the use of ‘base’ keyword in all context. 
using System;

abstract class Vehicle
{
    // Abstract method to be implemented by derived classes
    public abstract void DisplayInfo();

    // Non-abstract method (with 'virtual' keyword) to demonstrate 'base' usage
    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle engine started.");
    }
}

class Car : Vehicle
{
    private string brand;
    private string model;

    // Constructor to initialize Car details using base class (optional for inheriting properties)
    public Car(string brand, string model) 
    {
        this.brand = brand;
        this.model = model;
    }

    // Implementing the abstract method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Car Brand: {brand}, Model: {model}");
    }

    // Using 'base' keyword to call base class method
    public override void StartEngine()
    {
        base.StartEngine(); // Calling base class version of StartEngine
        Console.WriteLine($"Car {brand} engine started.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of derived class Car
        Car myCar = new Car("Toyota", "Corolla");

        // Calling methods
        myCar.DisplayInfo();      // Calls the overridden method from Car class
        myCar.StartEngine();      // Uses 'base' keyword to call the base method first
    }
}
