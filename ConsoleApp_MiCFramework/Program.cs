using MicFramework;
using MicFramework.Extensions;
using System.Globalization;

namespace ConsoleApp_MiCFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 25000.25697M;
            CultureInfo ci = new CultureInfo("en-us");
            string vv = price.ToString("C", ci);
            
            string value = price.ToMoneyFormat(RateType.Rub);
        }
    }
}
