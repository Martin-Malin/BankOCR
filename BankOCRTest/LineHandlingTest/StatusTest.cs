using BankOCR;

namespace BankOCRTest.LineHandlingTest
{
    [TestClass]
    public class StatusTest
    {
        [TestMethod]
        public void PassValidLine_ReturnsOK()
        {
            string line =
                "    _  _  _  _  _  _  _  _ \r\n" +
                "|_||_   ||_ | ||_|| || || |\r\n" +
                "  | _|  | _||_||_||_||_||_|\r\n" +
                "                           \r\n";

            LineHandling lineHandling = new LineHandling(line);

            LineHandling.LineStatus result = lineHandling.Status;

            Assert.AreEqual(LineHandling.LineStatus.OK, result);
        }

        [TestMethod]
        public void PassInvalidLine_ReturnsERR()
        {
            string line =
                "                           \r\n" +
                "  |  |  |  |  |  |  |  |  |\r\n" +
                "  |  |  |  |  |  |  |  |  |\r\n" +
                "                           \r\n";

            LineHandling lineHandling = new LineHandling(line);

            LineHandling.LineStatus result = lineHandling.Status;

            Assert.AreEqual(LineHandling.LineStatus.ERR, result);
        }

        [TestMethod]
        public void PassIllegibleLine_ReturnsILL()
        {
            string line =
                "    _  _     _  _  _  _  _ \r\n" +
                "  | _| _||_||  |_   | _||_|\r\n" +
                "  | _  _|  | _||_|  ||_| _|\r\n" +
                "                           \r\n";

            LineHandling lineHandling = new LineHandling(line);

            LineHandling.LineStatus result = lineHandling.Status;

            Assert.AreEqual(LineHandling.LineStatus.ILL, result);
        }
    }
}
