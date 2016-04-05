using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using RUPropisNumber.MEFAttributes;

namespace RUPropisNumber
{
    public static class Propis
    {
        static Propis()
        {
            var ass = Assembly.GetExecutingAssembly();
            AssemblyCatalog ac = new AssemblyCatalog(ass);
            CompositionContainer cc = new CompositionContainer(ac);
            cc.ComposeParts();
            var e = cc.GetExportedValues<ICurrencyPropis>();
            var exports = cc.GetExports<ICurrencyPropis, ICurrencyAttr>();
            currencies = new Dictionary<int, ICurrencyPropis>();
            foreach (var export in exports)
            {
                currencies.Add(export.Metadata.CurrencyID, export.Value);
            }
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

        public static string NumPhrase(ulong num, bool isMale)
        {
            return PropisInternal.NumPhrase(num, isMale);
        }
    }
}