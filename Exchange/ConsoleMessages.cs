/// <summary>
/// Currently using const strings for messages, but we can use resource file for strings.
/// </summary>

namespace Exchange
{
    public static class ConsoleMessages
    {
        public const string InvalidArgs = "Please pass the argument like<currency pair> <amount to exchange>";
        public const string InvalidPattern = "Please pass the argument like EUR/DKK 4";
        public const string InvalidMainCurrency = "Please pass a valid main currency";
        public const string InValidMoneyCurrency = "Please pass a valid money currency";
        public const string InvalidAmount = "Please pass valid amount";
    }
}
