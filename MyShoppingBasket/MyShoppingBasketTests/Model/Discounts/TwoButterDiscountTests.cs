using System.Collections.Generic;
using MyShoppingBasket.Model.Discounts;
using MyShoppingBasket.Model.Products;
using NUnit.Framework;

namespace MyShoppingBasketTests.Model.Discounts
{
    [TestFixture]
    public class TwoButterDiscountTests
    {
        [Test]
        public void GetDiscount_EmptyList_ExpectZero()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct>();

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(0, discount.Amount);
        }

        [Test]
        public void GetDiscount_OneButter_ExpectZero()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct>{new Butter()};

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(0, discount.Amount);
        }
        
        [Test]
        public void GetDiscount_TwoButter_ExpectZero()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct> { new Butter(), new Butter() };

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(0, discount.Amount);
        }

        [Test]
        public void GetDiscount_ThreeButter_ExpectZero()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct> { new Butter(), new Butter(), new Butter() };

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(0, discount.Amount);
        }

        [Test]
        public void GetDiscount_TwoButterOneBread_ExpectHalfBreadPrice()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct> { new Butter(), new Butter(), new Bread() };

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(new Bread().GetPricePerUnit().Amount/2, discount.Amount);
        }

        [Test]
        public void GetDiscount_TwoButterTwoBread_ExpectHalfBreadPrice()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct> { new Butter(), new Butter(), new Bread(), new Bread() };

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(new Bread().GetPricePerUnit().Amount / 2, discount.Amount);
        }
        
        [Test]
        public void GetDiscount_TwoBread_ExpectZero()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct> { new Bread(), new Bread() };

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(0, discount.Amount);
        }
        
        [Test]
        public void GetDiscount_OneBread_ExpectZero()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct> { new Bread(), };

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(0, discount.Amount);
        }

        [Test]
        public void GetDiscount_ThreButterTwoBread_ExpectHalfBreadPrice()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct> { new Butter(), new Butter(), new Butter(), new Bread(), new Bread() };

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(new Bread().GetPricePerUnit().Amount / 2, discount.Amount);
        }
        
        [Test]
        public void GetDiscount_FourButterTwoBread_ExpectFullBreadPrice()
        {
            // Arrange
            var tbdDiscount = new TwoButterDiscount();
            var products = new List<IProduct> { new Butter(), new Butter(), new Butter(), new Butter(), new Bread(), new Bread() };

            // Act
            var discount = tbdDiscount.GetDiscount(products);

            // Assert
            Assert.AreEqual(new Bread().GetPricePerUnit().Amount, discount.Amount);
        }
    }
}
