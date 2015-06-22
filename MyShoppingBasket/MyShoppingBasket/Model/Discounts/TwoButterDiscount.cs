using System;
using System.Collections.Generic;
using System.Linq;
using MyShoppingBasket.Model.Products;

namespace MyShoppingBasket.Model.Discounts
{
    public class TwoButterDiscount : IDiscount
    {
        public Money GetDiscount(IList<IProduct> products)
        {
            var nrOfButter = products.Count(_ => typeof(Butter) == _.GetType());
            var nrOfBread = products.Count(_ => typeof(Bread) == _.GetType());

            var nrOfButterPairs = Math.Abs(nrOfButter / 2);

            decimal discount = 0;
            var breadPrice = new Bread().GetPricePerUnit().Amount;
            foreach(var i in Enumerable.Range(0, Math.Min(nrOfButterPairs, nrOfBread)))
            {
                discount += breadPrice/2;
            }
            
            return new Money(discount);
        }
    }
}
