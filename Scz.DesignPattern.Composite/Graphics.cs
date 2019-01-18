using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Composite
{
    public abstract class Graphics
    {
        public string Name { get; private set; }
        public Graphics(string name)
        {
            this.Name = name;
        }

        public abstract void Draw();
    }
}