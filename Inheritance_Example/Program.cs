using System;

namespace SimpleInheritance
{
    // Base class
    public class Car
    {
        public string Brand { get; set; }

        public Car(string brand)
        {
            Brand = brand;
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving.");
        }
    }

    // Derived class
    public class SportsCar : Car
    {
        public SportsCar(string brand) : base(brand) { }

        public void TurboBoost()
        {
            Console.WriteLine($"{Brand} is using turbo boost!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota");
            myCar.Drive();

            SportsCar mySportsCar = new SportsCar("Ferrari");
            mySportsCar.Drive();
            mySportsCar.TurboBoost();
        }
    }
}
