using System;

namespace MoneyFramework
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class CultureNameAttribute : Attribute
    {
        public CultureNameAttribute(string cultureName)
        {
            CultureName = cultureName;
        }
        public string CultureName { get; private set;}
    }
}
