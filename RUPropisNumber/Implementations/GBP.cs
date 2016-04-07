using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using RUPropisNumber.MEFAttributes;

namespace RUPropisNumber.Implementations
{
    [ExportMetadata("CurrencyID", 826, IsMultiple = false)]
    [Export(typeof(ICurrencyPropis))]
    class GBP : ICurrencyPropis
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
