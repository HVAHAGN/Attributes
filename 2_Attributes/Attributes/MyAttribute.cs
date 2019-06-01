using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Attributes.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    class MyAttribute : System.Attribute
    {
        public MyAttribute(string date)
        {
            this.date = date;
        }

        private readonly string date;
        public string Date
        {
            get { return date; }
        }

        public int Number { get; set; }
    }
}