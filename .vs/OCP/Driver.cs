using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Driver
    {
        public Car Car { get; set; }
        public SuperCar SuperCar { get; set; }
        public Driver(Car car)
        {
            Car = car;
        }

        public Driver(SuperCar superCar)
        {
            SuperCar = superCar;
        }


        public void EhatCar()
        {
            Car.ehat();
        }

        public void SuperEhat()
        {
            SuperCar.SuperEhat();
        }
     

    }
}
