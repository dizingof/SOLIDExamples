using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class People : IGo
    {
        public void Go()
        {
            Console.WriteLine("People go");
        }
    }
}
