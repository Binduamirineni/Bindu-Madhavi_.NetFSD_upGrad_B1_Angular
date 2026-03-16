using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagementSystem
{
    // Base Class
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Brand { get; set; }

        // Constructor
        public Vehicle(string number, string brand)
        {
            VehicleNumber = number;
            Brand = brand;
        }

        public void StartVehicle()
        {
            Console.WriteLine("Vehicle Started");
        }
    }

    // Derived Class
    public class Car : Vehicle
    {
        public string FuelType { get; set; }

        // Constructor
        public Car(string number, string brand, string fuel)
            : base(number, brand)
        {
            FuelType = fuel;
        }
    }

    // Sealed Class
    public sealed class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }

        // Constructor
        public ElectricCar(string number, string brand, string fuel, int battery)
            : base(number, brand, fuel)
        {
            BatteryCapacity = battery;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Vehicle Number: " + VehicleNumber);
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Fuel Type: " + FuelType);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " kWh");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ElectricCar ec = new ElectricCar("EV1234", "Tesla", "Electric", 75);

            ec.StartVehicle();
            ec.DisplayDetails();
        }
    }
}