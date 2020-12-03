using System;

namespace lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 class1 = new Class1(20);
            Class2 class2= new Class2(30);

            class2 = class1 as Class2;
        }
    }
}
