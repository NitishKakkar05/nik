using System;
namespace ExchangeService
{
    /// <summary>
    /// Use <c>WebConversionServices</c> for online currency conversion APIs  
    /// </summary>
    internal class WebConversionServices : IConversionService
    {
        /// <summary>
        /// Convert main currency in money currency
        /// </summary>
        /// <param name="mainCurrency">Main currency</param>
        /// <param name="moneyCurrency">Money currency</param>
        /// <param name="amount">Amount to be converted</param>
        /// <returns>Converted amount in money currency.</returns>
        public decimal Convert(CurrencyEnum mainCurrency, CurrencyEnum moneyCurrency, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
