using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace Assignment1Test
{
    [TestClass]
    public class InternationNumberSystemTests
    {
        [TestMethod]
        public void TestZero()
        {
            INumberToWord system = new InternationalNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "Zero";

            string actual = numberSystem.Convert(0);

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void TestNegative()
        {
            INumberToWord system = new InternationalNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "Negative Ninety Nine";

            string actual = numberSystem.Convert(-99);

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void TestThousand()
        {
            INumberToWord system = new InternationalNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "Seven Thousand One";

            string actual = numberSystem.Convert(7001);

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void TestThousand1()
        {
            INumberToWord system = new InternationalNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "One Thousand";

            string actual = numberSystem.Convert(1000);

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void TestMillion()
        {
            INumberToWord system = new InternationalNumberSystem();
            NumberSystem numberSystem = new NumberSystem(system);
            string expected = "Twenty Three Million Four Hundred Fifty Six Thousand Seven Hundred Eighty Nine";

            string actual = numberSystem.Convert(23456789);

            Assert.AreEqual(expected, actual, false);
        }
    }
}
