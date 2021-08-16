using Exchange;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class ConsoleInputTest
    {
        [TestMethod]
        public void NoArgumentTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            Program.ConvertCurrency(new string[] { });
            Assert.AreEqual(ConsoleMessages.InvalidArgs, output.ToString());
        }

        [TestMethod]
        public void InvalidCurrencyFormatTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            Program.ConvertCurrency(new string[] { "DKK//DKK", "32" });
            Assert.AreEqual(ConsoleMessages.InvalidPattern, output.ToString());
        }

        [TestMethod]
        public void InvalidAmountTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            Program.ConvertCurrency(new string[] { "DKK/DKK", "amount" });
            Assert.AreEqual(ConsoleMessages.InvalidAmount, output.ToString());
        }

        [TestMethod]
        public void InvalidMainCurrencyTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            Program.ConvertCurrency(new string[] { "ABC/DKK", "32" });
            Assert.AreEqual(ConsoleMessages.InvalidMainCurrency, output.ToString());
        }

        [TestMethod]
        public void InvalidMoneyCurrencyTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            Program.ConvertCurrency(new string[] { "EUR/ABC", "32" });
            Assert.AreEqual(ConsoleMessages.InValidMoneyCurrency, output.ToString());
        }

        [TestMethod]
        public void ZeorCurrencyTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            Program.ConvertCurrency(new string[] { "EUR/DKK", "0" });
            Assert.AreEqual("0.0000", output.ToString());
        }

        [TestMethod]
        public void SameCurrencyTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            Program.ConvertCurrency(new string[] { "EUR/EUR", "2" });
            Assert.AreEqual("2.0000", output.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeAmountTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            Program.ConvertCurrency(new string[] { "EUR/EUR", "-2" });
        }

    }
}
