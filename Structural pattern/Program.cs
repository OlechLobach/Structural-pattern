using System;
using FacadeParts;
namespace FacadeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new CarFacade();

            Console.WriteLine("----- Starting Car -----");
            facade.StartCar();

            Console.WriteLine("\n----- Driving Car -----");
            facade.DriveCar();

            Console.WriteLine("\n----- Stopping Car -----");
            facade.StopCar();
        }
    }
}