using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.Builder
{
    public class ConcreteBuilder1 : Builder
    {
        Computer computer = new Computer();

        public override void BuildPartCpu()
        {
            computer.Add("CPU");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("主板");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
