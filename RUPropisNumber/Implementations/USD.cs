using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
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
            _big = new CurrencyPropis("доллар", "доллара", "долларов");
        }


        public string GetPropis(decimal sum)
        {
            return PropisInternal.CurPhrase(sum, _big, _small);
        }
    }
}
