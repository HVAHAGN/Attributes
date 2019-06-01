using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Student
    {
        [Description("BBBBBB")]
        [DisplayName("Անուն")]
        public string Name { get; set; }

        public string Surname { get; set; }

        [Browsable(false)]
        public string FullName => $"{Surname} {Name}";
        public byte Age { get; set; }
    }
}