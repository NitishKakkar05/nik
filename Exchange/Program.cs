using ExchangeService;
using System;
using System.Text.RegularExpressions;

namespace Exchange
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ConvertCurrency(args);
        }

        public static void ConvertCurrency(string[] args)
        {
            if (args.Length < 2)
            {
                Console.Write(ConsoleMessages.InvalidArgs);
                return;
            }


            Regex regex = new Regex("^[A-Z]{3}/[A-Z]{3}$", RegexOptions.None);

            if (!regex.IsMatch(args[0]))
            {
                Console.Write(ConsoleMessages.InvalidPattern);
                return;
            }

            string currencyPair = args[0];

            if (!Enum.TryParse(currencyPair.Substring(0, 3), out CurrencyEnum mainCurrency))
            {
                Console.Write(ConsoleMessages.InvalidMainCurrency);
                return;
            }

            if (!Enum.TryParse(currencyPair.Substring(4, 3), out CurrencyEnum moneyCurrency))
            {
                Console.Write(ConsoleMessages.InValidMoneyCurrency);
                return;
            }


            if (!decimal.TryParse(args[1], out decimal amount))
            {
                Console.Write(ConsoleMessages.InvalidAmount);
                return;
            }

            FxService fxService = new FxService(new InHouseConversionService());
            decimal dvalue = fxService.Exchange(mainCurrency, moneyCurrency, amount);
            Console.Write(dvalue.ToString("0.0000"));
        }
    }
}
