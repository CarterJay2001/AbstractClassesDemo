using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {

        }

        public Vehicle(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public int Year { get; set; } = 2021;

        public string Make { get; set; } = "Insert Make";

        public string Model { get; set; } = "Insert Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("We're driving!");
        }
    }
}
