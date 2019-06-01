#define TRIAL
//#define PREMIUM

using System;
using System.Diagnostics;
using System.Reflection;

namespace _4_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();

            test.Initialize();
            test.Trial();   // Вызывается только в том случае, если определен идентификатор TRIAL 
            test.Release(); // Вызывается только в том случае, если определен идентификатор RELEASE 
            Console.WriteLine(new string('-', 20));

            Type type = typeof(Test);

            MethodInfo[] methodInfo = type.GetMethods(
                BindingFlags.Public |         // Указывает, что в поиск должны быть включены открытые члены. 
                BindingFlags.NonPublic |      // Указывает, что в поиск должны быть включены члены экземпляра, не являющиеся открытыми.
                BindingFlags.Instance |       // Указывает, что в поиск должны быть включены члены экземпляра, не являющиеся открытыми.
                BindingFlags.DeclaredOnly);   // Определяет, что должны рассматриваться только члены, объявленные на уровне иерархии переданного типа. Наследуемые члены не учитываются.

            foreach (MethodInfo method in methodInfo)
            {
                Console.WriteLine(method.Name);
            }

            // Delay.
            Console.ReadKey();
        }
    }

    internal class Test
    {
        [Conditional("TRIAL")]
        internal void Trial()
        {
            Console.WriteLine("Trial Version.");
        }

        [Conditional("PREMIUM")]
        internal void Release()
        {
            Console.WriteLine("Premium Version.");
        }

#if DEBUG
        public void Initialize()
        {
            Console.WriteLine("Application Initialization in DEBUG mode.");
        }
#else
        public void Initialize()
        {
            Console.WriteLine("Application Initialization in RELEASE mode.");
        }
#endif
    }
}
