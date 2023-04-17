using BankOCR;

namespace BankOCRTest.LineToArrayTest
{
    [TestClass]
    public class GetArrayTest
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

            LineToArray lineToArray = new LineToArray(line);
            string[] resultArray = lineToArray.Array;

            Assert.AreEqual(9, resultArray.Length);
            for (int i = 0; i < 9; i++)
            {
                Assert.AreEqual(NumbersMapHelpers.digitMap[digitToTest], resultArray[i], $"Chiffre recherché : {digitToTest} ; Position : " + i);
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

            LineToArray lineToArray = new LineToArray(line);
            string[] resultArray = lineToArray.Array;

            Assert.AreEqual(9, resultArray.Length);
            Assert.AreEqual(NumbersMapHelpers.digitMap[1], resultArray[0]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[2], resultArray[1]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[3], resultArray[2]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[4], resultArray[3]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[5], resultArray[4]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[6], resultArray[5]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[7], resultArray[6]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[8], resultArray[7]);
            Assert.AreEqual(NumbersMapHelpers.digitMap[9], resultArray[8]);
        }
    }
}
