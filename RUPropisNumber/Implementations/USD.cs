using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;
using System.Threading.Tasks;
using RUPropisNumber.MEFAttributes;

namespace RUPropisNumber.Implementations
{
    [ExportMetadata("CurrencyID", 840, IsMultiple = false)]
    [Export(typeof(ICurrencyPropis))]
    class USD : ICurrencyPropis
    {
        private CurrencyPropis _small;
        private CurrencyPropis _big;

        public USD()
        {
            _small = new CurrencyPropis("цент", "цента", "центов");
            _big = new CurrencyPropis("доллар США", "доллара США", "долларов США");
        }


        public string GetPropis(decimal sum)
        {
            return PropisInternal.CurPhrase(sum, _big, _small);
        }
    }
}
