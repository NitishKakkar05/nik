using ExchangeService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class InHouseServiceTest
    {
        private IConversionService service = new InHouseConversionService();

        [TestMethod]
        public void InHouseServiceZeroAmountTest()
        {
            var convertedValue = service.Convert(CurrencyEnum.CHF, CurrencyEnum.DKK, 0);
            Assert.AreEqual(0, convertedValue);
        }

        [TestMethod]
        public void InHouseServiceSameCurrencyTest()
        {
            decimal amount = 30;
            var convertedValue = service.Convert(CurrencyEnum.EUR, CurrencyEnum.EUR, amount);
            Assert.AreEqual(amount, convertedValue);
        }

        [TestMethod]
        public void InHouseServiceConversionTest()
        {
            decimal amount = 1;
            var convertedValue = service.Convert(CurrencyEnum.EUR, CurrencyEnum.DKK, amount);
            Assert.AreEqual(7.4394M, convertedValue);
        }
    }
}
