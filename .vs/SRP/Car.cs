using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Car
    {
        private string Nmae { get; set; }
        public int Power { get; set; }
        public int Massa { get; set; }
        private int MaxSpeep { get; set; }

        public void GetName()
        {
            Console.WriteLine(Nmae);
            Massa = 100;
        }

        public void Go()
        {
            Console.WriteLine(MaxSpeep);
        }

        public void Plavat()
        {
            Console.WriteLine("Plivu");
        }

        public void Remontirovat()
        {
            Console.WriteLine("idet remont");
        }


    }
}
