using BankOCR;

namespace BankOCRTest.ChecksumTest
{
    [TestClass]
    public class IsValidTest
    {
        [TestMethod]
        public void GivenValidNumber_ShouldBeTrue()
        {
            List<string> validNumbers = new List<string>()
            {
                "457508000",
                "345882865",
                "490067719",
                "490067115",
                "490867715"
            };

            foreach (string number in validNumbers)
            {
                Checksum checksum = new Checksum(number);

                bool result = checksum.IsValid;

                Assert.IsTrue(result);
            }
        }

        [TestMethod]
        public void GivenInvalidNumber_ShouldBeFalse()
        {
            Checksum checksum = new Checksum("111111111");

            bool result = checksum.IsValid;

            Assert.IsFalse(result);
        }
    }
}
