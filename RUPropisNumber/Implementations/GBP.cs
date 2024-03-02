using RuPropisNumber.Interfaces;

namespace RuPropisNumber.Implementations
{
    internal class GBP : ICurrencyPropis
    {
        private CurrencyPropis _small;
        private CurrencyPropis _big;

        public GBP()
        {
            _small = new CurrencyPropis("пенни", "пенса", "пенсов");
            _big = new CurrencyPropis("фунт стерлингов", "фунта стерлингов", "фунтов стерлингов");
        }

        public string GetPropis(decimal sum)
        {
            return PropisInternal.CurPhrase(sum, _big, _small);
        }
    }
}