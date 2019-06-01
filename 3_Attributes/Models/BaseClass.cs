using System;
using _3_Attributes.Attributes;

namespace _3_Attributes.Models
{
    [My("Base", "1/1/1111")]
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Ctor BaseClass!!!");
        }
    }
}