using MyShoppingBasket.Model.Products;
using NUnit.Framework;

namespace MyShoppingBasketTests.Model.Products
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void GetPrice_Bread_ShouldReturnPrice()
        {
            var bread = new Bread();

            Assert.NotNull(bread.GetPricePerUnit());
        }

        [Test]
        public void GetPrice_Milk_ShouldReturnPrice()
        {
            var milk = new Milk();

            Assert.NotNull(milk.GetPricePerUnit());
        }

        [Test]
        public void GetPrice_Butter_ShouldReturnPrice()
        {
            var butter = new Butter();

            Assert.NotNull(butter.GetPricePerUnit());
        }
    }
}
