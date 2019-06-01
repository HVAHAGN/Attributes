using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value = 3555;
            //CultureInfo ci = new CultureInfo("hy-AM");
            //string money = value.ToString("C", ci);
            //string money = value.ToMoneyToString("hy-AM");
            string money = value.ToMoneyToString(MoneyType.TRL);
        }
    }
}
