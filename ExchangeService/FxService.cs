using System;

namespace ExchangeService
{
    public class FxService
    {
        private IConversionService conversionService;

        public FxService()
        {

        }

        public FxService(IConversionService conversionService)
        {
            this.conversionService = conversionService;
        }

        public void SetConversionService(IConversionService conversionService)
        {
            this.conversionService = conversionService;
        }

        /// <summary>
        /// Exchange main currency in money currency
        /// </summary>
        /// <param name="mainCurrency">Main currency</param>
        /// <param name="moneyCurrency">Money currency</param>
        /// <param name="amount">Amount to be changed</param>
        /// <returns>Converted amount in money currency.</returns>
        public decimal Exchange(CurrencyEnum mainCurrency, CurrencyEnum moneyCurrency, decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException($"{amount} is not a valid amount.");
            }

            if (mainCurrency == moneyCurrency)
            {
                return amount;
            }

            if (conversionService == null)
            {
                throw new Exception("Please set conversion service");
            }

            return conversionService.Convert(mainCurrency, moneyCurrency, amount);
        }
    }
}
