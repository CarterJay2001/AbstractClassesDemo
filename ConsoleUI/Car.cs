using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }

        public Car(int year, string make, string model, bool trunk)
        {
            Year = year;
            Make = make;
            Model = model;
            HasTrunk = trunk;
        }

        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("We made it!");

        }
    }
}
