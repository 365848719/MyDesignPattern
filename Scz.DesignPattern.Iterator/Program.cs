using System;

namespace Scz.DesignPattern.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            DoIteratorPattern();
        }

        /// <summary>
        /// 迭代器模式
        /// </summary>
        public static void DoIteratorPattern()
        {
            Iterator iterator;
            IListCollection list = new ConcreteList();
            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.GetCurrent());
                iterator.Next();
            }
        }
    }
}
