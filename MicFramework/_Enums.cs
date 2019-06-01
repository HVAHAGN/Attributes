using MicFramework.Attributes;

namespace MicFramework
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
        Afk,

        [RateInfo("ka-GE")]
        Geo,

        [RateInfo("ar-MA")]
        Mor
    }
}
