using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public Motorcycle(int year, string make, string model, bool cart)
        {
            Year = year;
            Make = make;
            Model = model;
            HasSideCart = cart;
        }

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Go go go!!!");

        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Go Go Gadget coding!");
        }
    }
}
