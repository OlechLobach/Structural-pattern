using System;
using DecoratorProxyProject;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeliveryService deliveryService = new DeliveryServiceProxy(new TrackingDecorator(new BasicDeliveryService()));

            Console.WriteLine(deliveryService.Deliver());
            Console.WriteLine("Estimated delivery time: " + deliveryService.GetDeliveryTime());
            Console.WriteLine("Total cost: $" + deliveryService.GetCost());
        }
    }
}