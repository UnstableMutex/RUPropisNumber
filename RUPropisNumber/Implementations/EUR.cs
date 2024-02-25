using RuPropisNumber.Interfaces;
using RuPropisNumber;
namespace RUPropisNumber.Implementations
{
    class EUR : ICurrencyPropis
    {
        private CurrencyPropis _small;
        private CurrencyPropis _big;
        public EUR()
        {
            _small = new CurrencyPropis("цент", "цента", "центов");
            _big = new CurrencyPropis("евро", "евро", "евро");
        }
        public string GetPropis(decimal sum)
        {
            return PropisInternal.CurPhrase(sum, _big, _small);
        }
    }
}
