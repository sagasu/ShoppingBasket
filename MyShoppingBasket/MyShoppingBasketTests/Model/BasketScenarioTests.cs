using MyShoppingBasket.Model;
using MyShoppingBasket.Model.Products;
using NUnit.Framework;

namespace MyShoppingBasketTests.Model
{
    [TestFixture]
    public class BasketScenarioTests
    {
        [Test]
        public void GetTotalPrice_AddOneButterOneMilkOneBread_ExpectScenarioPrice()
        {
            // Arrange
            var basket = new Basket();
            var butter = new Butter();
            var bread = new Bread();
            var milk = new Milk();
            basket.Add(butter);
            basket.Add(milk);
            basket.Add(bread);

            // Act
            var price = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(2.95, price.Amount);
        }
        
        [Test]
        public void GetTotalPrice_AddTwoButterAndTwoBread_ExpectScenarioPrice()
        {
            // Arrange
            var basket = new Basket();
            var butter = new Butter();
            var bread = new Bread();
            basket.Add(butter);
            basket.Add(butter);
            basket.Add(bread);
            basket.Add(bread);

            // Act
            var price = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(3.10, price.Amount);
        }

        [Test]
        public void GetTotalPrice_AddFourMilk_ExpectScenarioPrice()
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
            Assert.AreEqual(3.45, price.Amount);
        }

        [Test]
        public void GetTotalPrice_AddTwoButterAndOneBreadAndEightMilk_ExpectScenarioPrice()
        {
            // Arrange
            var basket = new Basket();
            var butter = new Butter();
            var bread = new Bread();
            var milk = new Milk();
            basket.Add(butter);
            basket.Add(butter);
            basket.Add(bread);
            basket.Add(milk);
            basket.Add(milk);
            basket.Add(milk);
            basket.Add(milk);
            basket.Add(milk);
            basket.Add(milk);
            basket.Add(milk);
            basket.Add(milk);

            // Act
            var price = basket.GetTotalPrice();

            // Assert
            Assert.AreEqual(9.0, price.Amount);
        }
    }
}
