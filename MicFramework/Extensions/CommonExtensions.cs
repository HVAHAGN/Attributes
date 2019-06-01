using MicFramework.Attributes;
using System.Globalization;
using System.Reflection;

namespace MicFramework.Extensions
{
    public static class CommonExtensions
    {
        public static string ToMoneyFormat(this decimal value, RateType rateType)
        {
            FieldInfo fi = rateType.GetType().GetField(rateType.ToString());
            RateInfoAttribute ria = fi.GetCustomAttribute<RateInfoAttribute>();

            CultureInfo ci = new CultureInfo(ria.CultureName);
            return value.ToString("C", ci);
        }
    }
}
