﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    interface IComputer
    {
        void PlayGame(string gameName);
        void DoWork(string workName);
        void Freeze(int degree);
    }
}
