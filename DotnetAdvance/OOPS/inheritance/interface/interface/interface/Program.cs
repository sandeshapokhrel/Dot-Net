using System;

interface IVehicle
{
 
    void Drive();

    // default implementation 
    void Refuel()
    {
        Console.WriteLine("Refueling the vehicle...");
    }
}

class Car : IVehicle
{
    // interface method
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}

class Bike : IVehicle
{
    // interface method
    public void Drive()
    {
        Console.WriteLine("Riding a bike");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IVehicle myCar = new Car();
        IVehicle myBike = new Bike();

        myCar.Drive();  
        myCar.Refuel(); 

        myBike.Drive(); 
        myBike.Refuel(); 
    }
}
