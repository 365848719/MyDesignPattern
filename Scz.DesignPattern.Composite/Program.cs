using System;

namespace Scz.DesignPattern.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            DoComposite();
        }

        /// <summary>
        /// 组合模式
        /// </summary>
        public static void DoComposite()
        {
            ComplexGraphics graphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
            graphics.Add(new Line("线段A"));

            ComplexGraphics complexComposite = new ComplexGraphics("一个圆和一个线段");
            complexComposite.Add(new Circle("一个圆"));
            complexComposite.Add(new Line("线段B"));

            graphics.Add(complexComposite);

            Line l = new Line("线段C");
            graphics.Add(l);

            // 显示复杂图形的画法
            Console.WriteLine("复杂图形的绘制如下：");
            Console.WriteLine("---------------------");

            graphics.Draw();

            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("---------------------");
            Console.WriteLine();


            // 移除一个组件再显示复杂图形的画法
            graphics.Remove(l);
            Console.WriteLine("移除线段C后，复杂图形的绘制如下：");
            Console.WriteLine("---------------------");
            graphics.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("---------------------");
            Console.Read();
        }

    }
}
