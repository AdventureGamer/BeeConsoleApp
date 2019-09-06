using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesConsoleApp
{
    public class Queen : Bee
    {
        public Queen(string name)
        {
            this.beeObjectName = name;
            this.FlyingEndurance = 20;
        }
    }
}
