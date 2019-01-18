using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scz.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 蔬菜
    /// </summary>
    public abstract class Vegetabel
    {
        public void Cook()
        {
            Console.WriteLine("抄蔬菜的一般做法");

            PourOil();
            HeatOil();
            PourVegetabel();
            StirFry();
        }

        protected  void PourOil()
        {
            Console.WriteLine("倒油");
        }
        protected  void HeatOil()
        {
            Console.WriteLine("把油烧热");
        }
        protected abstract void PourVegetabel();
        protected  void StirFry()
        {
            Console.WriteLine("翻炒");
        }
    }
}