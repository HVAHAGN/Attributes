using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Attributes.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
    public class MyAttribute : System.Attribute
    {
        private readonly string text;
        private readonly string data;

        public MyAttribute(string text, string data)
        {
            this.text = text;
            this.data = data;
        }

        public void Method()
        {
            Console.WriteLine("Attribute Method");
        }

        public string Text
        {
            get { return text; }
        }

        public string Data
        {
            get { return (data); }
        }
    }
}
