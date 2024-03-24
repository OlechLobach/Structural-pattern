using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeParts
{
    public class CarFacade
    {
        private readonly Engine _engine;
        private readonly Transmission _transmission;

        public CarFacade()
        {
            _engine = new Engine();
            _transmission = new Transmission();
        }

        public void StartCar()
        {
            _engine.Start();
            _transmission.Drive();
        }

        public void DriveCar()
        {
            _transmission.Drive();
        }

        public void StopCar()
        {
            _transmission.Park();
            _engine.Stop();
        }
    }
}