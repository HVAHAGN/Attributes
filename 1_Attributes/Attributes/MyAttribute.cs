using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Attributes.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    class MyAttribute : System.Attribute
    {
        public MyAttribute(string date)
        {
            this.date = date;
        }

        public MyAttribute(string date, int number)
            : this(date)
        {
            Number = number;
        }

        private readonly string date;
        public string Date
        {
            get { return date; }
        }

        public int Number { get; set; }
    }
}
