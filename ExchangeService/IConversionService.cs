namespace ExchangeService
{
    public interface IConversionService
    {
        /// <summary>
        /// Convert main currency in money currency
        /// </summary>
        /// <param name="mainCurrency">Main currency</param>
        /// <param name="moneyCurrency">Money currency</param>
        /// <param name="amount">Amount to be converted</param>
        /// <returns>Converted amount in money currency.</returns>
        decimal Convert(CurrencyEnum mainCurrency, CurrencyEnum moneyCurrency, decimal amount);
    }
}
