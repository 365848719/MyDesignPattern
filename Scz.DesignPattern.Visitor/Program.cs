using System;

namespace Scz.DesignPattern.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            DoVisitorPattern();
        }

        /// <summary>
        /// 访问者模式
        /// </summary>
        public static void DoVisitorPattern()
        {
            ObjectStructure s = new ObjectStructure();
            foreach (var item in s.Elements)
            {
                item.Accept(new ConcreteVisitor());
            }
        }

    }
}
