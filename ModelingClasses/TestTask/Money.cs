using static TestTask.Enumeration;

namespace TestTask
{
    internal class Money
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }

        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
