using System;

namespace MyShoppingBasket.Model
{
    public class Money
    {
        public const string DEFAULT_CURRENCY = "£";

        public Money(decimal amount)
        {
            Currency = DEFAULT_CURRENCY;
            Amount = amount;
        }

        public String Currency { get; set; }
        public Decimal Amount { get; set; }

        public static Money operator +(Money x, Money y)
        {
            return new Money(x.Amount + y.Amount);
        }

        public static Money operator *(Money x, Money y)
        {
            return new Money(x.Amount * y.Amount);
        }

        public static Money operator -(Money x, Money y)
        {
            return new Money(x.Amount - y.Amount);
        }

        public static Money operator /(Money x, Money y)
        {
            return new Money(x.Amount - y.Amount);
        }
    }
}
