using BankOCR;

namespace BankOCRTest.NumberOCRTest
{
    [TestClass]
    public class NumberTest
    {
        [TestMethod]
        public void GivenZero_ReturnsZero()
        {
            string number =
                " _ " +
                "| |" +
                "|_|";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void GivenOne_ReturnsOne()
        {
            string number =
                "   " +
                "  |" +
                "  |";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("1", result);
        }
        [TestMethod]
        public void GivenTwo_ReturnsTwo()
        {
            string number =
                " _ " +
                " _|" +
                "|_ ";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("2", result);
        }
        [TestMethod]
        public void GivenThree_ReturnsThree()
        {
            string number =
                " _ " +
                " _|" +
                " _|";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("3", result);
        }
        [TestMethod]
        public void GivenFour_ReturnsFour()
        {
            string number =
                "   " +
                "|_|" +
                "  |";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("4", result);
        }
        [TestMethod]
        public void GivenFive_ReturnsFive()
        {
            string number =
                " _ " +
                "|_ " +
                " _|";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("5", result);
        }
        [TestMethod]
        public void GivenSix_ReturnsSix()
        {
            string number =
                " _ " +
                "|_ " +
                "|_|";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("6", result);
        }
        [TestMethod]
        public void GivenSeven_ReturnsSeven()
        {
            string number =
                " _ " +
                "  |" +
                "  |";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("7", result);
        }
        [TestMethod]
        public void GivenEight_ReturnsEight()
        {
            string number =
                " _ " +
                "|_|" +
                "|_|";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("8", result);
        }
        [TestMethod]
        public void GivenNine_ReturnsNine()
        {
            string number =
                " _ " +
                "|_|" +
                " _|";

            DigitOCR ocr = new DigitOCR(number);
            string result = ocr.Digit;

            Assert.AreEqual("9", result);
        }

        [TestMethod]
        public void GivenIllegible_ReturnsInterrogationMark()
        {
            List<string> illegibleNumbers = new List<string>()
            {
                "   " +
                "|_|" +
                " _|",

                " _ " +
                " _|" +
                "|_|",

                " _ " +
                " _|" +
                " _ ",

                "  " +
                "|_|" +
                "   ",

                "   " +
                "   " +
                "   "
            };

            foreach (string number in illegibleNumbers)
            {
                DigitOCR ocr = new DigitOCR(number);
                string result = ocr.Digit;

                Assert.AreEqual("?", result);
            }
        }
    }
}