using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Driver driver = new Driver(car);
            SuperDriver superDriver = new SuperDriver();
            driver.Drive();
            superDriver.Drive();
            Console.ReadKey();
        }
    }
}
