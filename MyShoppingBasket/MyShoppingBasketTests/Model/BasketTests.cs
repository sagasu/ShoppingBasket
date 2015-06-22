using MyShoppingBasket.Model;
using MyShoppingBasket.Model.Products;
using NUnit.Framework;

namespace MyShoppingBasketTests.Model
{
    [TestFixture]
    public class BasketTests
    {
        [Test]
        public void GetTotalPrice_NoProductsAdded_ExpectZero()
        {
            // Arrange
            var basket = new Basket();

            // Act
            var price = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(0, price.Amount);
        }

        [Test]
        public void GetTotalPrice_AddOneMilk_ExpectMilkPrice()
        {
            // Arrange
            var basket = new Basket();
            var milk = new Milk();
            basket.Add(milk);

            // Act
            var price = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(milk.GetPricePerUnit().Amount, price.Amount);
        }
        
        [Test]
        public void GetTotalPrice_AddOneBread_ExpectBreadPrice()
        {
            // Arrange
            var basket = new Basket();
            var bread = new Bread();
            basket.Add(bread);

            // Act
            var price = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(bread.GetPricePerUnit().Amount, price.Amount);
        }
        
        [Test]
        public void GetTotalPrice_AddTwoButter_ExpectTwoButterPrice()
        {
            // Arrange
            var basket = new Basket();
            var butter = new Butter();
            basket.Add(butter);
            basket.Add(butter);

            // Act
            var price = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(butter.GetPricePerUnit().Amount*2, price.Amount);
        }
        
        [Test]
        public void GetTotalPrice_AddFourMilk_ExpectThreeMilkPrice()
        {
            // Arrange
            var basket = new Basket();
            var milk = new Milk();
            basket.Add(milk);
            basket.Add(milk);
            basket.Add(milk);
            basket.Add(milk);

            // Act
            var price = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(milk.GetPricePerUnit().Amount*3, price.Amount);
        }
        
        [Test]
        public void GetTotalPrice_AddTwoButterAndOneBread_Expect50PrecentBreadDiscount()
        {
            // Arrange
            var basket = new Basket();
            var butter = new Butter();
            var bread = new Bread();
            basket.Add(butter);
            basket.Add(butter);
            basket.Add(bread);

            // Act
            var price = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(butter.GetPricePerUnit().Amount*2 + bread.GetPricePerUnit().Amount/2, price.Amount);
        }
    }
}
