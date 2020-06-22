using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class Competition
    {
        private IGo Member;

        public Competition(IGo member)
        {
            Member = member;
        }
    }
}
