// Demonstrate the use of this, static constructor and object initializers in a real world class and implement.

/* object initializer is a way to create an object and initialize its properties in a single step,
 without explicitly calling a parameterized constructor. */
using System;

internal class CarDealership
{
    // Static field to track the total number of cars
    public class Car
    {
        public static int TotalCars;

        // Properties of the car
        public int Model { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }

        // Static constructor to initialize static fields
        static Car()
        {
            TotalCars = 0;
            Console.WriteLine("Total number of cars initialized to 0 at first.");
        }

        // Default constructor calling parameterized constructor using 'this'
        public Car() : this(1, "Brand name", 500000)
        {
            Console.WriteLine("Default constructor called.");
        }

        // Parameterized constructor
        public Car(int model, string brand, float price)
        {
            this.Model = model;
            this.Brand = brand;
            this.Price = price;
            TotalCars++;
            Console.WriteLine($"Car: Model {Model}, Brand {Brand}, Price {Price}, Total Cars: {TotalCars}");
        }

        // Method to display car details
        public void DisplayMethod()
        {
            Console.WriteLine("The model is " + Model);
            Console.WriteLine("The brand is " + Brand);
            Console.WriteLine("The price is " + Price);
        }
    }
}

public class MainProgram
{
    static void Main(string[] args)
    {
        // Using object initializer syntax
        CarDealership.Car car1 = new CarDealership.Car { Model = 1, Brand = "Toyota", Price = 20000 };
        car1.DisplayMethod();

        // Using parameterized constructor
        CarDealership.Car car2 = new CarDealership.Car(2, "Mustang", 30000);
        car2.DisplayMethod();
    }
}


