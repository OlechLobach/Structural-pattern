using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DecoratorPattern
{
    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }

    public class EconomyCar : ICar
    {
        public string GetDescription()
        {
            return "Economy Car";
        }

        public double GetCost()
        {
            return 20000.0;
        }
    }

    public abstract class CarDecorator : ICar
    {
        protected ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual string GetDescription()
        {
            return car.GetDescription();
        }

        public virtual double GetCost()
        {
            return car.GetCost();
        }
    }

    public class SportsPackage : CarDecorator
    {
        public SportsPackage(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return $"{car.GetDescription()} with Sports Package";
        }

        public override double GetCost()
        {
            return car.GetCost() + 3000.0;
        }
    }

    public class LuxuryPackage : CarDecorator
    {
        public LuxuryPackage(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return $"{car.GetDescription()} with Luxury Package";
        }

        public override double GetCost()
        {
            return car.GetCost() + 5000.0;
        }
    }
}
