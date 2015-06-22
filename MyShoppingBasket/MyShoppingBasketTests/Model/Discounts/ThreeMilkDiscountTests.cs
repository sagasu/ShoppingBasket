using System.Collections.Generic;
using MyShoppingBasket.Model.Discounts;
using MyShoppingBasket.Model.Products;
using NUnit.Framework;

namespace MyShoppingBasketTests.Model.Discounts
{
    [TestFixture]
    public class ThreeMilkDiscountTests
    {
        [Test]
        public void GetDiscount_EmptyList_ExpectZero()
        {
            // Arrange
            var tmDiscount = new ThreeMilkDiscount();
            var products = new List<IProduct>();

            // Act
            var discount = tmDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(0, discount.Amount);
        }
        
        [Test]
        public void GetDiscount_ThreeMilk_ExpectZero()
        {
            // Arrange
            var tmDiscount = new ThreeMilkDiscount();
            var products = new List<IProduct> { new Milk(), new Milk(), new Milk() };

            // Act
            var discount = tmDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(0, discount.Amount);
        }
        
        [Test]
        public void GetDiscount_FourMilk_ExpectMilkPrice()
        {
            // Arrange
            var tmDiscount = new ThreeMilkDiscount();
            var products = new List<IProduct> { new Milk(), new Milk(), new Milk(), new Milk() };

            // Act
            var discount = tmDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(new Milk().GetPricePerUnit().Amount, discount.Amount);
        }
    }
}
