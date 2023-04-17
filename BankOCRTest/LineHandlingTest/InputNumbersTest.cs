using BankOCR;

namespace BankOCRTest.LineHandlingTest
{
    [TestClass]
    public class InputNumbersTest
    {
        [TestMethod]
        public void PassLineOfNumbers_ReturnsArrayOfDigits()
        {
            for (int i = 0; i < 10; i++)
            {
                PassLineOfX_ReturnsArrayOfX(i);
            }
        }

        public void PassLineOfX_ReturnsArrayOfX(int digitToTest)
        {
            string line = NumbersMapHelpers.digitsLineMap[digitToTest];

            LineHandling lineOCR = new LineHandling(line);
            string[] result = lineOCR.Digits;

            Assert.AreEqual(9, result.Length);
            for (int i = 0; i < 9; i++)
            {
                Assert.AreEqual(digitToTest.ToString(), result[i], $"Chiffre recherché : {digitToTest} ; Position : " + i);
            }
        }

        [TestMethod]
        public void PassLineOfAllNumbers_ReturnsArrayOfAllNumbers()
        {
            string line =
                "    _  _     _  _  _  _  _ \r\n" +
                "  | _| _||_||_ |_   ||_||_|\r\n" +
                "  ||_  _|  | _||_|  ||_| _|\r\n" +
                "                           \r\n";

            LineHandling lineOCR = new LineHandling(line);
            var result = lineOCR.Digits;

            Assert.AreEqual(9, result.Length);
            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("2", result[1]);
            Assert.AreEqual("3", result[2]);
            Assert.AreEqual("4", result[3]);
            Assert.AreEqual("5", result[4]);
            Assert.AreEqual("6", result[5]);
            Assert.AreEqual("7", result[6]);
            Assert.AreEqual("8", result[7]);
            Assert.AreEqual("9", result[8]);
        }

        [TestMethod]
        public void PassLineWithIlligible_ReturnsArrayWithIllegible()
        {
            string line =
                "    _  _     _  _  _  _  _ \r\n" +
                "  | _| _||_||  |_   | _||_|\r\n" +
                "  | _  _|  | _||_|  ||_| _|\r\n" +
                "                           \r\n";

            LineHandling lineOCR = new LineHandling(line);
            var result = lineOCR.Digits;

            Assert.AreEqual(9, result.Length);
            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("?", result[1]);
            Assert.AreEqual("3", result[2]);
            Assert.AreEqual("4", result[3]);
            Assert.AreEqual("?", result[4]);
            Assert.AreEqual("6", result[5]);
            Assert.AreEqual("7", result[6]);
            Assert.AreEqual("?", result[7]);
            Assert.AreEqual("9", result[8]);
        }
    }
}
