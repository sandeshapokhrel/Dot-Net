//Example for Class and Object 
using System;
public class Car
{
    public string make;
    public string model;
    public int year;

    public Car(string make, string model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Car Make: " + make);
        Console.WriteLine("Car Model: " + model);
        Console.WriteLine("Car Year: " + year);
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Car class
            Car myCar = new Car("Toyota", "Corolla", 2020);

          
            myCar.DisplayInfo();
        }
    }

}
