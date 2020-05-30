using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace Assignment1Test
{
    [TestClass]
    public class IndianNumberSystemTests
    {
        [TestMethod]
        public void TestZero()
        {
            INumberToWord system = new IndianNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "Zero";

            string actual = numberSystem.Convert(0);

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void TestNegative()
        {
            INumberToWord system = new IndianNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "Negative Ninety Nine";

            string actual = numberSystem.Convert(-99);

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void TestThousand()
        {
            INumberToWord system = new IndianNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "Seven Thousand One";

            string actual = numberSystem.Convert(7001);

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void TestThousand1()
        {
            INumberToWord system = new IndianNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "One Thousand";

            string actual = numberSystem.Convert(1000);

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void TestLakh()
        {
            INumberToWord system = new IndianNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "Fifty Five Lakh Fifty Five Thousand Five Hundred Fifty Five";

            string actual = numberSystem.Convert(5555555);

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void TestCrore()
        {
            INumberToWord system = new IndianNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "Fifty Two Crore Thirty Four Lakh Fifty Six Thousand Seven Hundred Eighty Nine";

            string actual = numberSystem.Convert(523456789);

            Assert.AreEqual(expected, actual, false);
        }
    }
}
