using System.Collections.Generic;

namespace MyShoppingBasket.Model.Products
{
    public class Bread : IProduct
    {
        public Money GetPricePerUnit()
        {
            return new Money(1M);
        }
    }
}
