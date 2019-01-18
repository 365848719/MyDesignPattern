using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.Prototype
{
    public interface IColorDemo
    {
        IColorDemo Clone();
        object DeepClone();
        ColorPicker Picker { get; set; }
        int Red { get; set; }
        int Green { get; set; }
        int Blue { get; set; } 
        string Name { get; set; }
    }
}