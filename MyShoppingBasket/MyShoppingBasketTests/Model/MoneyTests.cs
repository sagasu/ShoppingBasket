using MyShoppingBasket.Model;
using NUnit.Framework;

namespace MyShoppingBasketTests.Model
{
    [TestFixture]
    class MoneyTests
    {
        [Test]
        public void Money_CreateMoney_ReturnsAmountWithPoundCurrency()
        {
            var amount = 2.3M;
            var money = new Money(amount);
            Assert.AreEqual(amount, money.Amount);
            Assert.AreEqual(Money.DEFAULT_CURRENCY, money.Currency);
        }
    }
}
