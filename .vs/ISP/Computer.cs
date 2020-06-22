using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Computer : IComputer
    {
        public void DoWork(string workName)
        {
            throw new NotImplementedException();
        }

        public void Freeze(int degree)
        {
            throw new NotImplementedException();
        }

        public void PlayGame(string gameName)
        {
            throw new NotImplementedException();
        }
    }
}
