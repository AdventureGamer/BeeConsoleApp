using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesConsoleApp
{
    class Drone : Bee
    {
        public Drone(string name)
        {
            this.beeObjectName = name;
            this.FlyingEndurance = 50;
        }
    }
}
