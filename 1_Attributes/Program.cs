using System;
using _1_Attributes.Attributes;
using System.Globalization;

namespace _1_Attributes
{
    [My("1/31/2016", Number = 1)]
    public class MyClass
    {
        [My("2/31/2007", 10)]
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()\n");
        }
    }

    class Program
    {
        static void Main()
        {
            var my = new MyClass();
            MyClass.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
