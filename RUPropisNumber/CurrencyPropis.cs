namespace RuPropisNumber
{
    public class CurrencyPropis
    {
        public CurrencyPropis(string p1, string p2, string p5)
        {
            _propis1 = p1;
            _propis2 = p2;
            _propis5 = p5;
        }

        private string _propis1;
        private string _propis2;
        private string _propis5;

        public string Propis1
        {
            get { return _propis1; }
            set { _propis1 = value; }
        }

        public string Propis2
        {
            get { return _propis2; }
            set { _propis2 = value; }
        }

        public string Propis5
        {
            get { return _propis5; }
            set { _propis5 = value; }
        }
    }
}