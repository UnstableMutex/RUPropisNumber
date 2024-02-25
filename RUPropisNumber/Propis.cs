using RuPropisNumber.Implementations;
using RuPropisNumber.Interfaces;
using RUPropisNumber.Implementations;

namespace RuPropisNumber
{
    public static class Propis
    {
        static Propis()
        {
            Dictionary<int, ICurrencyPropis> exports = new Dictionary<int, ICurrencyPropis>()
            { {978, new EUR()}, {826, new GBP()}, {643, new RUB()}, {840, new USD()}};
            currencies = exports;
        }
        public static void SetCurrencies(Dictionary<int, ICurrencyPropis> cur)
        {
            currencies = cur;
        }
        private static Dictionary<int, ICurrencyPropis> currencies;

        /// <summary>
        /// Расписывает денежную сумму словами
        /// </summary>
        /// <param name="sum">Денежная сумма</param>
        /// <param name="ISOValute">iso код валюты</param>
        /// <returns>пропись денежной суммы</returns>
        public static string CurrencyPhrase(decimal sum, int ISOValute)
        {
            var cur = currencies[ISOValute];
            return cur.GetPropis(sum);
        }
        /// <summary>
        /// Расписывает число словами
        /// </summary>
        /// <param name="num">число</param>
        /// <param name="isMale">Необходимый род числа = true - мужской, false - женский</param>
        /// <returns></returns>
        public static string NumPhrase(ulong num, bool isMale)
        {
            return PropisInternal.NumPhrase(num, isMale);
        }
    }
}