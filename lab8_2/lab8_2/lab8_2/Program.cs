using System;

namespace lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            calendar calendar = new calendar(25, 11,2020);
            Console.WriteLine(calendar.calculate(5, 10, 2020));
        }
    }
}
