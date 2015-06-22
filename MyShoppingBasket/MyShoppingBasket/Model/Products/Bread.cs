using System.Collections.Generic;

namespace MyShoppingBasket.Model.Products
{
    public class Bread : IProduct
    {
        public static Money Price = new Money(1M);

        public Money GetPricePerUnit()
        {
            return Price;
        }
    }
}
