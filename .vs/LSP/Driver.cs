using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Driver
    {
        public Car Car { get; set; }

        public Driver(Car car)
        {
            Car = car;
        }

       

        public void Drive()
        {
            Console.WriteLine($"Drive {Car.Rul} metod iz bazovogo classa");
        }
    }
}
