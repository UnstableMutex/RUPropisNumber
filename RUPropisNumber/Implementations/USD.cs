﻿using RuPropisNumber.Interfaces;

namespace RuPropisNumber.Implementations
{
    internal class USD : ICurrencyPropis
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