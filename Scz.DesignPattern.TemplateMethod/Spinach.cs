using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 菠菜
    /// </summary>
    public class Spinach : Vegetabel
    {
        protected override void PourVegetabel()
        {
            Console.WriteLine("倒菠菜进锅中");
        }
    }
}