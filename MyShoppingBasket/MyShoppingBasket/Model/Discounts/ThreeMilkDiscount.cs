using System;
using System.Collections.Generic;
using System.Linq;
using MyShoppingBasket.Model.Products;

namespace MyShoppingBasket.Model.Discounts
{
    public class ThreeMilkDiscount : IDiscount
    {
        public Money GetDiscount(IList<IProduct> products)
        {
            var nrOfMilk = products.Count(_ => typeof (Milk) == _.GetType());
            var nrOfFreeMilk = Math.Abs(nrOfMilk/4);
            return new Milk().GetPricePerUnit() * new Money(nrOfFreeMilk);
        }
    }
}
