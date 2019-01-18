using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scz.DesignPattern.Builder
{
   public class Director2
    {
        public Computer Construct(Builder builder)
        {
            builder.BuildPartCpu();
            builder.BuildPartMainBoard();

            return builder.GetComputer();
        }
    }
}
