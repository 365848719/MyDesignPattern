using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 大白菜
    /// </summary>
    public class ChineseCabagge : Vegetabel
    {
        protected override void PourVegetabel()
        {
            Console.WriteLine("倒大白菜进锅中");
        }
    }
}