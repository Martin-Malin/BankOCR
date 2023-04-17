using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankOCR
{
    public class DigitOCR
    {
        private static readonly Dictionary<string, string> digitMap = new Dictionary<string, string>()
            {
                {" _ " +
                 "| |" +
                 "|_|", "0"},
                {"   " +
                 "  |" +
                 "  |", "1"},
                {" _ " +
                 " _|" +
                 "|_ ", "2"},
                {" _ " +
                 " _|" +
                 " _|", "3"},
                {"   " +
                 "|_|" +
                 "  |", "4"},
                {" _ " +
                 "|_ " +
                 " _|", "5"},
                {" _ " +
                 "|_ " +
                 "|_|", "6"},
                {" _ " +
                 "  |" +
                 "  |", "7"},
                {" _ " +
                 "|_|" +
                 "|_|", "8"},
                {" _ " +
                 "|_|" +
                 " _|", "9"}
            };

        private string _input;

        public string Digit
        {
            get
            {
                try
                {
                    return digitMap[_input];
                }
                catch(KeyNotFoundException)
                {
                    return "?";
                }
            }
        }

        public DigitOCR(string input)
        {
            this._input = input;
        }
    }
}
