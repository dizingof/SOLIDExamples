﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            Competition competitionDog = new Competition(new Dog());
            Competition competitionPeople = new Competition(new People());
        }
    }
}