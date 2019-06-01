using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoneyFramework
{
    static class MicExtention
    {
        public static string ToMoneyToString(this decimal value, MoneyType moneyType)
        {
            string cultureName = moneyType.GetCultureName();
            CultureInfo ci = new CultureInfo(cultureName);
            return value.ToString("C", ci);
        }
        public static string GetCultureName(this MoneyType moneyType)
        {
            MemberInfo mi = moneyType.GetType().GetMember(moneyType.ToString()).First();
            var cna= mi.GetCustomAttribute<CultureNameAttribute>();
            if (cna == null)
                throw new Exception();
            return cna.CultureName;
        }
    }
}
