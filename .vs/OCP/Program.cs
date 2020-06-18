using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Driver driver = new Driver(car);
            driver.EhatCar();



            //SuperCar superCar = new SuperCar();
            //Driver driver = new Driver(superCar);
            //driver.SuperEhat();



            Console.ReadLine();
        }
    }
}
