using System;

namespace RuPropisNumber
{
    public class PropisFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg is decimal)
            {
                return FormatDecimal(format, (decimal)arg);
            }
            if (arg is int)
            {
                return FormatDecimal(format, (int)arg);
            }

            throw new FormatException();
        }

        private static string FormatDecimal(string format, decimal arg)
        {
            int valID;
            decimal o = arg;
            bool b = int.TryParse(format, out valID);
            string result;
            if (b)
            {
                result = Propis.CurrencyPhrase(o, valID);
                return result;
            }
            if (format.ToLower() == "n0") //female num
            {
                result = Propis.NumPhrase((ulong)o, false);
                return result;
            }
            if (format.ToLower() == "n1") //male num
            {
                result = Propis.NumPhrase((ulong)o, true);
                return result;
            }
            throw new FormatException();
        }
    }
}