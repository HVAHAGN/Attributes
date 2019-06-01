using ConsoleAppCurency.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCurency
{
    public enum RateType
    {
        [RateInfo("hy-AM")]
        Amd,
        [RateInfo("en-US")]
        Usd,
        [RateInfo("ru-RU")]
        Rub,
        [RateInfo("af-ZA")]
        Afk
    }
}
