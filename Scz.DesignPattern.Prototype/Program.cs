using System;

namespace Scz.DesignPattern.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Do();
        }

        /// <summary>
        /// 原型模式
        /// </summary>
        public static void Do()
        {
            ColorPicker picker = new ColorPicker(200, 1, 90);
            picker.Name = "拾色器";

            IColorDemo color = new RedColor();
            color.Red = 255;
            color.Picker = picker;
            color.Name = "红色";

            IColorDemo color1 = color.Clone();
            color1.Red = 234;
            color1.Name = "红色2";

            IColorDemo color2 = color.DeepClone() as IColorDemo;

            Console.WriteLine(color.Blue == color1.Blue);
            Console.WriteLine(color.Blue == color2.Blue);

            Console.WriteLine("Picker 是否：{0}", color.Picker == color2.Picker);

            Console.WriteLine("Deep Copy 的对象，是否相等：{0}", color.Picker == color2.Picker);

            Console.WriteLine("两个对象是否相等：{0}", color.Equals(color2));
            Console.ReadKey();
        }

    }
}
