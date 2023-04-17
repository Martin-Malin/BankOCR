namespace BankOCR
{
    public class LineToArray
    {
        public string Line { get; }

        private string[] _Array;
        public string[] Array
        {
            get
            {
                if (_Array is null)
                    computeArray();

                return _Array;
            }
        }


        private const int LineNumber = 3;
        private const int NumberOfCharactersByLine = 27;
        private const int NumberOfDigitsByLine = NumberOfCharactersByLine / LineNumber;
        private const int NumberWidth = 3;

        private string[] _SplitedLines;
        private string[] SplitedLines
        {
            get
            {
                if (_SplitedLines is null)
                    _SplitedLines = Line.Split("\r\n"); ;

                return _SplitedLines;
            }
        }

        public LineToArray(string line)
        {
            Line = line;
        }

        private void computeArray()
        {
            _Array = new string[NumberOfDigitsByLine];
            for (int i = 0; i < NumberOfDigitsByLine; i++)
            {
                for (int j = 0; j < LineNumber; j++)
                {
                    _Array[i] += SplitedLines[j].Substring(i * NumberWidth, NumberWidth);
                }
            }
        }
    }
}
