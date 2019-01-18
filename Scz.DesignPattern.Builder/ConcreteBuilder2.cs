using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.Builder
{
    class ConcreteBuilder2 : Builder
    {
        Computer computer = new Computer();

        public override void BuildPartCpu()
        {
            computer.Add("CPU2");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("主板2");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
