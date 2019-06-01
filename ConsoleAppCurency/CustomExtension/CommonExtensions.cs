using ConsoleAppCurency.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCurency.CustomExtension
{
    public static class CommonExtensions
    {
        public static string ToMoneyFormat(this decimal value, RateType rateType)
        {
            FieldInfo fi = typeof(RateType).GetField(rateType.ToString());
            RateInfoAttribute ria = fi.GetCustomAttribute<RateInfoAttribute>();

            CultureInfo ci = new CultureInfo(ria.CultureName);
            return value.ToString("C", ci);
        }
    }
}