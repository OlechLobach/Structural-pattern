using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DecoratorProxyProject
{
    public interface IDeliveryService
    {
        string Deliver();
        TimeSpan GetDeliveryTime();
        decimal GetCost();
    }

    public class BasicDeliveryService : IDeliveryService
    {
        public string Deliver()
        {
            return "Basic delivery service";
        }

        public TimeSpan GetDeliveryTime()
        {
            return TimeSpan.FromDays(3); 
        }

        public decimal GetCost()
        {
            return 0; 
        }
    }

   
    public class DeliveryServiceProxy : IDeliveryService
    {
        private readonly IDeliveryService _deliveryService;

        public DeliveryServiceProxy(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public string Deliver()
        {
            return "Delivery is not available at the moment. Please try again later.";
        }

        public TimeSpan GetDeliveryTime()
        {
            return TimeSpan.Zero;
        }

        public decimal GetCost()
        {
            return 0;
        }
    }

    public class TrackingDecorator : IDeliveryService
    {
        private readonly IDeliveryService _deliveryService;

        public TrackingDecorator(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public string Deliver()
        {
            return _deliveryService.Deliver() + ", with tracking";
        }

        public TimeSpan GetDeliveryTime()
        {
            return _deliveryService.GetDeliveryTime().Add(TimeSpan.FromDays(1)); 
        }

        public decimal GetCost()
        {
            return _deliveryService.GetCost() + 3; 
        }
    }
}