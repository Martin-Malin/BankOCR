namespace BankOCR
{
    public class LineHandling
    {
        public string InputLine { get; }

        private string[] _InputArray;
        public string[] InputArray
        {
            get
            {
                if (_InputArray is null)
                    computeInputArray();

                return _InputArray;
            }
        }

        private string[] _Digits;
        public string[] Digits
        {
            get
            {
                if (_Digits is null)
                    computeDigits();

                return _Digits;
            }
        }

        public string Output
        {
            get
            {
                return string.Join("", Digits);
            }
        }

        public LineStatus Status
        {
            get
            {
                if (Output.Contains("?"))
                    return LineStatus.ILL;
                else if(!this.Checksum.IsValid)
                    return LineStatus.ERR;
                
                return LineStatus.OK;
            }
        }

        private Checksum _Checksum;
        private Checksum Checksum
        {
            get
            {
                if(_Checksum is null)
                    _Checksum = new Checksum(Output);
                
                return _Checksum;
            }
        }

        private const int NumberOfDigitsByLine = 9;

        public LineHandling(string line)
        {
            InputLine = line;
        }

        private void computeDigits()
        {
            _Digits = new string[NumberOfDigitsByLine];
            for (int i = 0; i < NumberOfDigitsByLine; i++)
            {
                var digitOCR = new DigitOCR(InputArray[i]);
                _Digits[i] = digitOCR.Digit;
            }
        }

        private void computeInputArray()
        {
            var lineToArray = new LineToArray(InputLine);

            _InputArray = lineToArray.Array;
        }
        
        public enum LineStatus
        {
            OK,
            ILL,
            ERR
        }
    }
}
