using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesConsoleApp
{
    class Worker : Bee
    {
        public Worker(string name)
        {
            this.beeObjectName = name;
            this.FlyingEndurance = 70;
        }
    }
}
