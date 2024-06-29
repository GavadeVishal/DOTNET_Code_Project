using System;

class Vehicle
{
    public virtual void DisplayInfo()
    {
        Console.WriteLine("This is a vehicle.");
    }
}

class Car : Vehicle
{
    public override void DisplayInfo()
    {
        Console.WriteLine("This is a car.");
    }
}

class SportsCar : Car
{
    public override void DisplayInfo()
    {
        Console.WriteLine("This is a sports car.");
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle = new Vehicle();
        vehicle.DisplayInfo(); 

        Car car = new Car();
        car.DisplayInfo(); 

        SportsCar sportsCar = new SportsCar();
        sportsCar.DisplayInfo(); 

        DisplayVehicleInfo(vehicle); 
        DisplayVehicleInfo(car);     
        DisplayVehicleInfo(sportsCar); 
    }

    static void DisplayVehicleInfo(Vehicle vehicle)
    {
        vehicle.DisplayInfo();
    }
}
