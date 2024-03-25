using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DecoratorPattern
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

    public abstract class DeliveryServiceDecorator : IDeliveryService
    {
        protected IDeliveryService _deliveryService;

        public DeliveryServiceDecorator(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public virtual string Deliver()
        {
            if (_deliveryService != null)
            {
                return _deliveryService.Deliver();
            }
            else
            {
                return string.Empty;
            }
        }

        public virtual TimeSpan GetDeliveryTime()
        {
            if (_deliveryService != null)
            {
                return _deliveryService.GetDeliveryTime();
            }
            else
            {
                return TimeSpan.Zero;
            }
        }

        public virtual decimal GetCost()
        {
            if (_deliveryService != null)
            {
                return _deliveryService.GetCost();
            }
            else
            {
                return 0;
            }
        }
    }

    public class TrackingDecorator : DeliveryServiceDecorator
    {
        public TrackingDecorator(IDeliveryService deliveryService) : base(deliveryService)
        {
        }

        public override string Deliver()
        {
            return base.Deliver() + ", with tracking";
        }

        public override TimeSpan GetDeliveryTime()
        {
            return base.GetDeliveryTime().Add(TimeSpan.FromDays(1)); 
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 3; 
        }
    }

   
    public class ExpressDeliveryDecorator : DeliveryServiceDecorator
    {
        public ExpressDeliveryDecorator(IDeliveryService deliveryService) : base(deliveryService)
        {
        }

        public override string Deliver()
        {
            return base.Deliver() + ", express delivery";
        }

        public override TimeSpan GetDeliveryTime()
        {
            return base.GetDeliveryTime().Subtract(TimeSpan.FromDays(2)); 
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 10; 
        }
    }


}