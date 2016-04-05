using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;
using System.Threading.Tasks;
using RUPropisNumber.MEFAttributes;

namespace RUPropisNumber.Implementations
{


    [ExportMetadata("CurrencyID", 643, IsMultiple = false)]
    [Export(typeof(ICurrencyPropis))]
    class RUB : ICurrencyPropis
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
