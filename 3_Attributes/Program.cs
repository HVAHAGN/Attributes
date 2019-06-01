using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _3_Attributes.Attributes;
using _3_Attributes.Models;

namespace _3_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            // MemberInfo - абстрактный класс, используется для получения информации о членах класса. 
            MemberInfo type = typeof(MyClass);

            // Метод GetCustomAttributes() - возвращает массив объектов, которые при выполнении приложения
            // представляют собой эквиваленты атрибутов, созданных в исходном коде.
            // Извлекаем из элементов массива элементы типа - MyAttribute.
            object[] attributes = type.GetCustomAttributes(typeof(MyAttribute), true);

            // Если в массиве есть соответствующие записи, то первый элемент представляет собой атрибут - MyAttribute.
            if (attributes.Length != 0)
            {
                // Отображаем полученные значения.
                foreach (MyAttribute attribute in attributes)
                {
                    Console.WriteLine(attribute.Text);
                    Console.WriteLine(attribute.Data);
                    attribute.Method();
                }
            }

            //Задержка.
            Console.ReadKey();
        }
    }
}