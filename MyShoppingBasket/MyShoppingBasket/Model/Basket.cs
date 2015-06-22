using System.Collections.Generic;
using MyShoppingBasket.Model.Discounts;
using MyShoppingBasket.Model.Products;
using MyShoppingBasket.Extensions;

namespace MyShoppingBasket.Model
{
    public class Basket
    {
        private readonly IList<IProduct> _productStore = new List<IProduct>();
        private readonly IList<IDiscount>  _discounts = new List<IDiscount>{new ThreeMilkDiscount(), new TwoButterDiscount()};

        public void Add(IProduct product)
        {
            _productStore.Add(product);
        }

        public Money GetTotalPrice()
        {
            var priceWoDiscounts = _productStore.Sum(_ => _.GetPricePerUnit());

            var discount = _discounts.Sum(_ => _.GetDiscount(_productStore));

            return priceWoDiscounts - discount;
        }
    }
}
