namespace ExchangeService
{
    /// <summary>
    /// This class provide currency converion mechanism using DKK as base currency.
    /// </summary>
    public class InHouseConversionService : IConversionService
    {
        private const decimal EUR = 7.4394M;
        private const decimal USD = 6.6311M;
        private const decimal GBP = 8.5285M;
        private const decimal SEK = .7610M;
        private const decimal NOK = .7840M;
        private const decimal CHF = 6.8358M;
        private const decimal JPY = .059740M;
        private const decimal DKK = 1M;

        /// <summary>
        /// Convert the currency in DKK
        /// </summary>
        /// <param name="currencyEnum">Currency Value</param>
        /// <returns>Returns the equivalent in DKK</returns>
        private static decimal getConversion(CurrencyEnum currencyEnum)
        {
            switch (currencyEnum)
            {
                case CurrencyEnum.EUR: return EUR;
                case CurrencyEnum.USD: return USD;
                case CurrencyEnum.GBP: return GBP;
                case CurrencyEnum.SEK: return SEK;
                case CurrencyEnum.NOK: return NOK;
                case CurrencyEnum.CHF: return CHF;
                case CurrencyEnum.JPY: return JPY;
                case CurrencyEnum.DKK: return DKK;

                default: return 0;
            }
        }

        /// <summary>
        /// Convert main currency in money currency
        /// </summary>
        /// <param name="mainCurrency">Main currency</param>
        /// <param name="moneyCurrency">Money currency</param>
        /// <param name="amount">Amount to be converted</param>
        /// <returns>Converted amount in money currency.</returns>
        public decimal Convert(CurrencyEnum mainCurrency, CurrencyEnum moneyCurrency, decimal amount)
        {

            decimal factor = getConversion(mainCurrency) / getConversion(moneyCurrency);
            return factor * amount;
        }

    }
}
