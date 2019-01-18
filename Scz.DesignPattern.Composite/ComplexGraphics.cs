using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Composite
{
    public class ComplexGraphics : Graphics
    {
        List<Graphics> graphicsList = new List<Graphics>();
        public ComplexGraphics(string name) : base(name)
        {

        }

        public  void Add(Graphics g)
        {
            graphicsList.Add(g);
        }

        public override void Draw()
        {
            graphicsList.ForEach(x => x.Draw());
        }

        public  void Remove(Graphics g)
        {
            graphicsList.Remove(g);
        }
    }
}