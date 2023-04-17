using BankOCR;

namespace BankOCRTest.LineHandlingTest
{
    [TestClass]
    public class DigitsTest
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
            var result = lineOCR.InputArray;

            Assert.AreEqual(9, result.Length);
            for (int i = 0; i < 9; i++)
            {
                Assert.AreEqual(NumbersMapHelpers.digitMap[digitToTest], result[i], $"Chiffre recherché : {digitToTest} ; Position : " + i);
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
            var result = lineOCR.InputArray;

            Assert.AreEqual(9, result.Length);
            Assert.AreEqual(NumbersMapHelpers.digitMap[1], result[0]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[2], result[1]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[3], result[2]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[4], result[3]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[5], result[4]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[6], result[5]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[7], result[6]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[8], result[7]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[9], result[8]);
        }
    }
}
