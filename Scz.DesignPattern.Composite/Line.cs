using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Composite
{
    public class Line : Graphics
    {
        public Line(string name) : base(name) { }


        public override void Draw()
        {
            Console.WriteLine(string.Format("画：{0}", Name));
        }
  
    }
}