using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _2_Attributes.Attributes;

namespace _2_Attributes
{
    [My("1/31/2008", Number = 1)]
    public class MyClass
    {
        [My("2/31/2007", Number = 2)]
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()\n");
        }
    }

    class Program
    {
        static void Main()
        {
            //MyClass my = new MyClass();
            //MyClass.Method();

            Type type = typeof(MyClass);
            MyAttribute[] my = type.GetCustomAttributes<MyAttribute>().ToArray();


            object[] attributes = null;

            MyAttribute attribute = null;

            // Анализ атрибутов типа.
            // Получаем все аттрибуты заданного типа MyAttribute (false  - без проверки базовых классов).
            attributes = type.GetCustomAttributes(false);

            foreach (object attributeType in attributes)
            {
                attribute = attributeType as MyAttribute;
                Console.WriteLine("Анализ типа  : Number = {0}, Date = {1}", attribute.Number, attribute.Date);
            }

            MyAttribute aaa = type.GetCustomAttribute<MyAttribute>();

            // Анализ атрибутов метода.
            // Получаем public static метод - Method.
            MethodInfo method = type.GetMethod("Method", BindingFlags.Public | BindingFlags.Static);
            
            // Получаем все аттрибуты заданного типа MyAttribute (false - без проверки базовых классов).
            attributes = method.GetCustomAttributes(typeof(MyAttribute), false);

            foreach (MyAttribute attrib in attributes)
            {
                Console.WriteLine("Анализ метода: Number = {0}, Date = {1}", attrib.Number, attrib.Date);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
