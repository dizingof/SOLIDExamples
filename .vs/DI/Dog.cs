using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class Dog : IGo
    {
        public void Go()
        {
            Console.WriteLine("Dog go");
        }
    }
}
