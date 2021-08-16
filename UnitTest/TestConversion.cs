using ExchangeService.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// These tests are written to show fakes in case of actual web service.
/// </summary>

namespace UnitTest
{
    [TestClass]
    public class TestConversion
    {
        [TestMethod]
        public void TestZeroAmount()
        {
            StubIConversionService conversionService = new StubIConversionService()
            {
                ConvertCurrencyEnumCurrencyEnumDecimal = (mainCurrency, moneyCurrency, amount) => { return 0; }
            };

            var test = new StubFxService(conversionService);
            var convertedValue = test.Exchange(ExchangeService.CurrencyEnum.CHF, ExchangeService.CurrencyEnum.DKK, 0);

            Assert.AreEqual(0, convertedValue);
        }

        [TestMethod]
        public void TestSameCurrency()
        {
            var amountValue = 5;

            StubIConversionService conversionService = new StubIConversionService()
            {
                ConvertCurrencyEnumCurrencyEnumDecimal = (mainCurrency, moneyCurrency, amount) =>
                {
                    return amount;
                }
            };

            var test = new StubFxService(conversionService);
            var convertedValue = test.Exchange(ExchangeService.CurrencyEnum.EUR, ExchangeService.CurrencyEnum.EUR, amountValue);

            Assert.AreEqual(amountValue, convertedValue);
        }

    }
}
