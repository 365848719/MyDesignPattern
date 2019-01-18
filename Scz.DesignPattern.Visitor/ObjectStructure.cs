using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Visitor
{
    public class ObjectStructure
    {
        public List<Element> Elements { get; set; }

        public ObjectStructure()
        {
            Elements = new List<Element>();

            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
                int randomNumber = r.Next(10);
                if(randomNumber > 5)
                {
                    Elements.Add(new ElementA());
                }
                else
                {
                    Elements.Add(new ElementB());
                }
            }
        }
    }
}