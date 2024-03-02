using RuPropisNumber.Interfaces;

namespace RuPropisNumber.Implementations
{
    internal class RUB : ICurrencyPropis
    {
        private CurrencyPropis _small;
        private CurrencyPropis _big;

        public RUB()
        {
            _small = new CurrencyPropis("копейка", "копейки", "копеек");
            _big = new CurrencyPropis("рубль", "рубля", "рублей");
        }

        public string GetPropis(decimal sum)
        {
            return PropisInternal.CurPhrase(sum, _big, _small);
        }
    }
}