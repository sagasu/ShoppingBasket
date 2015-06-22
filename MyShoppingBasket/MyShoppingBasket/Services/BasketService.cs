using System;
using System.Collections.Generic;
using System.Linq;
using MyShoppingBasket.Model;
using MyShoppingBasket.Model.Products;

namespace MyShoppingBasket.Services
{
    public class BasketService
    {
        public Money GetTotalMoney(IList<IProduct> products)
        {
            var butterNr = products.Count(_ => _.GetType() == typeof(Butter));
            var breadNr = products.Count(_ => _.GetType() == typeof(Bread));
            var milkNr = products.Count(_ => _.GetType() == typeof (Milk));

            var nrOfFreeMilks = Math.Abs(milkNr/4);
            var nrOfButterPairs = Math.Abs(butterNr/2);

            //var butterPrice = butterNr * Butter.
            return new Money(0);
        }
    }
}
