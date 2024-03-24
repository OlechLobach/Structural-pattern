using System;
using DecoratorPattern;
namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar economyCar = new EconomyCar();
            Console.WriteLine($"Description: {economyCar.GetDescription()}, Cost: ${economyCar.GetCost()}");

            ICar sportsCar = new SportsPackage(economyCar);
            Console.WriteLine($"Description: {sportsCar.GetDescription()}, Cost: ${sportsCar.GetCost()}");

            ICar luxuryCar = new LuxuryPackage(economyCar);
            Console.WriteLine($"Description: {luxuryCar.GetDescription()}, Cost: ${luxuryCar.GetCost()}");

            ICar luxurySportsCar = new LuxuryPackage(sportsCar);
            Console.WriteLine($"Description: {luxurySportsCar.GetDescription()}, Cost: ${luxurySportsCar.GetCost()}");
        }
    }
}