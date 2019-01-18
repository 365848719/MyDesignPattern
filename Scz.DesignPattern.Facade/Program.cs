using System;

namespace Scz.DesignPattern.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SelectCourse();

            Console.Read();
        }
    }
}
