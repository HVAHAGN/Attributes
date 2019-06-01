using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CbaTestApp_Soap
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [DisplayName("Anun")]
        [Description("Bla Bla Bla Bla")]
        [Category("Readonly")]
        public string Fullname => $"{Surname} {Name}";

        [Browsable(false)]
        public string Email { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Fullname;
        }
    }
}