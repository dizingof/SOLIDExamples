using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class SuperDriver : Driver
    {
        

        public SuperDriver() : base(new Car())
        {
            Car = new Car();
        }


    }
}
