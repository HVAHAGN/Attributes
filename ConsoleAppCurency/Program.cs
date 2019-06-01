using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppCurency.CustomExtension;
using System.Globalization;

namespace ConsoleAppCurency
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 25.25697M;

            //CultureInfo ci = new CultureInfo("hy-AM");
            CultureInfo ci = new CultureInfo("en-US");
            string valueTest = price.ToString("C", ci);

            string valueTest1 = price.ToMoneyFormat(RateType.Afk);

            string value = price.ToMoneyFormat(RateType.Usd);
            string valueAmd = price.ToMoneyFormat(RateType.Amd);
            string valueRu = price.ToMoneyFormat(RateType.Rub);
        }
    }
}