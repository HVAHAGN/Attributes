using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyFramework
{

    public enum MoneyType
    {
        [CultureName("hy-AM")] AMD,
        [CultureName("ru-RU")]
        RUR,
        [CultureName("tr-TR")]
        TRL
    }
    //public class MoneyType
    //{
    //    public const string AMD = "hy-AM";
    //}
}
