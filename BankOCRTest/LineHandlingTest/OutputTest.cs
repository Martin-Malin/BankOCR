using BankOCR;

namespace BankOCRTest.LineHandlingTest
{
    [TestClass]
    public class OutputTest
    {
        [TestMethod]
        public void PassLineOfNumbers_ReturnsLineOfNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                PassLineOfX_ReturnsLineofX(i);
            }
        }

        public void PassLineOfX_ReturnsLineofX(int numberToTest)
        {
            string line = NumbersMapHelpers.digitsLineMap[numberToTest];

            LineHandling lineOCR = new LineHandling(line);
            string result = lineOCR.Output;

            Assert.AreEqual(9, result.Length);
            Assert.AreEqual(NumbersMapHelpers.outputNumbers[numberToTest], result);
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
            var result = lineOCR.Output;

            Assert.AreEqual(9, result.Length);
            Assert.AreEqual("123456789", result);
        }
    }
}
