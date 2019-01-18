using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Builder
{
    public class Director
    {
        public void Constructor(IBuilder builder)
        {
            builder.CreateLogo();
            builder.CreateBody();
            builder.CreateWheel();
            builder.CreateChair();
        }
    }
}