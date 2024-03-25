using DecoratorPattern;
using System;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeliveryService deliveryService = new BasicDeliveryService();
            deliveryService = new TrackingDecorator(deliveryService);
            deliveryService = new ExpressDeliveryDecorator(deliveryService);

            Console.WriteLine(deliveryService.Deliver());
            Console.WriteLine("Estimated delivery time: " + deliveryService.GetDeliveryTime());
            Console.WriteLine("Total cost: $" + deliveryService.GetCost());
        }
    }
}