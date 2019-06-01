using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyFramework
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    class CultureNameAttribute : Attribute
    {
        public CultureNameAttribute(string cultureName)
        {
            CultureName = cultureName;
        }
        public string CultureName { get; private set;}

    }
}
